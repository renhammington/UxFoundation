using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace Ux.Mvc.Web.UI
{
    public class Attachment
    {
        public byte[] Bytes
        {
            get
            {
                if (!HasNewFile) return null;
                var fileData = new byte[ContentLength];
                UploadedFile.InputStream.Read(fileData, 0, ContentLength);
                return fileData;
            }
        }

        /// <summary>
        /// Returns the length of the attached file, in bytes.
        /// </summary>
        public int ContentLength
        {
            get
            {
                if (!HasNewFile) return -1;
                return UploadedFile.ContentLength;
            }
        }


        /// <summary>
        /// Returns the MIME type of the attached file.
        /// </summary>
        public string ContentType
        {
            get
            {
                if (!HasNewFile) return null;
                return UploadedFile.ContentType;
            }
        }

        /// <summary>
        /// Returns the file extention of the attached file.
        /// </summary>
        public string Extension
        {
            get
            {
                if (!HasNewFile) return null;
                return Path.GetExtension(UploadedFile.FileName);
            }
        }

        /// <summary>
        /// Returns the full filename of the attached file.
        /// </summary>
        public string Filename
        {
            get
            {
                if (!HasNewFile) return null;
                return Path.GetFileName(UploadedFile.FileName);
            }
        }
        public HttpPostedFileBase UploadedFile { get; set; }

        public bool HasNewFile
        {
            get
            {
                return UploadedFile != null;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1},{2})", Filename, ContentType, ContentLength.ToFriendlyFileSize());
        }

        
    }
}