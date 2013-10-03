﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

namespace Ux.Mvc.Web.UI
{
	public static class CssClassMaps
	{


		public static Dictionary<IconType, string> IconCssMap = new Dictionary<IconType, string>() {
			{ IconType.Glass,"glass" },
			{ IconType.Music,"music" },
			{ IconType.Search,"search" },
			{ IconType.EnvelopeAlt,"envelope-alt" },
			{ IconType.Heart,"heart" },
			{ IconType.Star,"star" },
			{ IconType.StarEmpty,"star-empty" },
			{ IconType.User,"user" },
			{ IconType.Film,"film" },
			{ IconType.ThLarge,"th-large" },
			{ IconType.Th,"th" },
			{ IconType.ThList,"th-list" },
			{ IconType.Ok,"ok" },
			{ IconType.Remove,"remove" },
			{ IconType.ZoomIn,"zoom-in" },
			{ IconType.ZoomOut,"zoom-out" },
			{ IconType.Off,"off" },
			{ IconType.Signal,"signal" },
			{ IconType.Cog,"cog" },
			{ IconType.Trash,"trash" },
			{ IconType.Home,"home" },
			{ IconType.FileAlt,"file-alt" },
			{ IconType.Time,"time" },
			{ IconType.Road,"road" },
			{ IconType.DownloadAlt,"download-alt" },
			{ IconType.Download,"download" },
			{ IconType.Upload,"upload" },
			{ IconType.Inbox,"inbox" },
			{ IconType.PlayCircle,"play-circle" },
			{ IconType.Repeat,"repeat" },
			{ IconType.Refresh,"refresh" },
			{ IconType.ListAlt,"list-alt" },
			{ IconType.Lock,"lock" },
			{ IconType.Flag,"flag" },
			{ IconType.Headphones,"headphones" },
			{ IconType.VolumeOff,"volume-off" },
			{ IconType.VolumeDown,"volume-down" },
			{ IconType.VolumeUp,"volume-up" },
			{ IconType.Qrcode,"qrcode" },
			{ IconType.Barcode,"barcode" },
			{ IconType.Tag,"tag" },
			{ IconType.Tags,"tags" },
			{ IconType.Book,"book" },
			{ IconType.Bookmark,"bookmark" },
			{ IconType.Print,"print" },
			{ IconType.Camera,"camera" },
			{ IconType.Font,"font" },
			{ IconType.Bold,"bold" },
			{ IconType.Italic,"italic" },
			{ IconType.TextHeight,"text-height" },
			{ IconType.TextWidth,"text-width" },
			{ IconType.AlignLeft,"align-left" },
			{ IconType.AlignCenter,"align-center" },
			{ IconType.AlignRight,"align-right" },
			{ IconType.AlignJustify,"align-justify" },
			{ IconType.List,"list" },
			{ IconType.IndentLeft,"indent-left" },
			{ IconType.IndentRight,"indent-right" },
			{ IconType.FacetimeVideo,"facetime-video" },
			{ IconType.Picture,"picture" },
			{ IconType.Pencil,"pencil" },
			{ IconType.MapMarker,"map-marker" },
			{ IconType.Adjust,"adjust" },
			{ IconType.Tint,"tint" },
			{ IconType.Edit,"edit" },
			{ IconType.Share,"share" },
			{ IconType.Check,"check" },
			{ IconType.Move,"move" },
			{ IconType.StepBackward,"step-backward" },
			{ IconType.FastBackward,"fast-backward" },
			{ IconType.Backward,"backward" },
			{ IconType.Play,"play" },
			{ IconType.Pause,"pause" },
			{ IconType.Stop,"stop" },
			{ IconType.Forward,"forward" },
			{ IconType.FastForward,"fast-forward" },
			{ IconType.StepForward,"step-forward" },
			{ IconType.Eject,"eject" },
			{ IconType.ChevronLeft,"chevron-left" },
			{ IconType.ChevronRight,"chevron-right" },
			{ IconType.PlusSign,"plus-sign" },
			{ IconType.MinusSign,"minus-sign" },
			{ IconType.RemoveSign,"remove-sign" },
			{ IconType.OkSign,"ok-sign" },
			{ IconType.QuestionSign,"question-sign" },
			{ IconType.InfoSign,"info-sign" },
			{ IconType.Screenshot,"screenshot" },
			{ IconType.RemoveCircle,"remove-circle" },
			{ IconType.OkCircle,"ok-circle" },
			{ IconType.BanCircle,"ban-circle" },
			{ IconType.ArrowLeft,"arrow-left" },
			{ IconType.ArrowRight,"arrow-right" },
			{ IconType.ArrowUp,"arrow-up" },
			{ IconType.ArrowDown,"arrow-down" },
			{ IconType.ShareAlt,"share-alt" },
			{ IconType.ResizeFull,"resize-full" },
			{ IconType.ResizeSmall,"resize-small" },
			{ IconType.Plus,"plus" },
			{ IconType.Minus,"minus" },
			{ IconType.Asterisk,"asterisk" },
			{ IconType.ExclamationSign,"exclamation-sign" },
			{ IconType.Gift,"gift" },
			{ IconType.Leaf,"leaf" },
			{ IconType.Fire,"fire" },
			{ IconType.EyeOpen,"eye-open" },
			{ IconType.EyeClose,"eye-close" },
			{ IconType.WarningSign,"warning-sign" },
			{ IconType.Plane,"plane" },
			{ IconType.Calendar,"calendar" },
			{ IconType.Random,"random" },
			{ IconType.Comment,"comment" },
			{ IconType.Magnet,"magnet" },
			{ IconType.ChevronUp,"chevron-up" },
			{ IconType.ChevronDown,"chevron-down" },
			{ IconType.Retweet,"retweet" },
			{ IconType.ShoppingCart,"shopping-cart" },
			{ IconType.FolderClose,"folder-close" },
			{ IconType.FolderOpen,"folder-open" },
			{ IconType.ResizeVertical,"resize-vertical" },
			{ IconType.ResizeHorizontal,"resize-horizontal" },
			{ IconType.BarChart,"bar-chart" },
			{ IconType.TwitterSign,"twitter-sign" },
			{ IconType.FacebookSign,"facebook-sign" },
			{ IconType.CameraRetro,"camera-retro" },
			{ IconType.Key,"key" },
			{ IconType.Cogs,"cogs" },
			{ IconType.Comments,"comments" },
			{ IconType.ThumbsUpAlt,"thumbs-up-alt" },
			{ IconType.ThumbsDownAlt,"thumbs-down-alt" },
			{ IconType.StarHalf,"star-half" },
			{ IconType.HeartEmpty,"heart-empty" },
			{ IconType.Signout,"signout" },
			{ IconType.LinkedinSign,"linkedin-sign" },
			{ IconType.Pushpin,"pushpin" },
			{ IconType.ExternalLink,"external-link" },
			{ IconType.Signin,"signin" },
			{ IconType.Trophy,"trophy" },
			{ IconType.GithubSign,"github-sign" },
			{ IconType.UploadAlt,"upload-alt" },
			{ IconType.Lemon,"lemon" },
			{ IconType.Phone,"phone" },
			{ IconType.CheckEmpty,"check-empty" },
			{ IconType.BookmarkEmpty,"bookmark-empty" },
			{ IconType.PhoneSign,"phone-sign" },
			{ IconType.Twitter,"twitter" },
			{ IconType.Facebook,"facebook" },
			{ IconType.Github,"github" },
			{ IconType.Unlock,"unlock" },
			{ IconType.CreditCard,"credit-card" },
			{ IconType.Rss,"rss" },
			{ IconType.Hdd,"hdd" },
			{ IconType.Bullhorn,"bullhorn" },
			{ IconType.Bell,"bell" },
			{ IconType.Certificate,"certificate" },
			{ IconType.HandRight,"hand-right" },
			{ IconType.HandLeft,"hand-left" },
			{ IconType.HandUp,"hand-up" },
			{ IconType.HandDown,"hand-down" },
			{ IconType.CircleArrowLeft,"circle-arrow-left" },
			{ IconType.CircleArrowRight,"circle-arrow-right" },
			{ IconType.CircleArrowUp,"circle-arrow-up" },
			{ IconType.CircleArrowDown,"circle-arrow-down" },
			{ IconType.Globe,"globe" },
			{ IconType.Wrench,"wrench" },
			{ IconType.Tasks,"tasks" },
			{ IconType.Filter,"filter" },
			{ IconType.Briefcase,"briefcase" },
			{ IconType.Fullscreen,"fullscreen" },
			{ IconType.Group,"group" },
			{ IconType.Link,"link" },
			{ IconType.Cloud,"cloud" },
			{ IconType.Beaker,"beaker" },
			{ IconType.Cut,"cut" },
			{ IconType.Copy,"copy" },
			{ IconType.PaperClip,"paper-clip" },
			{ IconType.Save,"save" },
			{ IconType.SignBlank,"sign-blank" },
			{ IconType.Reorder,"reorder" },
			{ IconType.ListUl,"list-ul" },
			{ IconType.ListOl,"list-ol" },
			{ IconType.Strikethrough,"strikethrough" },
			{ IconType.Underline,"underline" },
			{ IconType.Table,"table" },
			{ IconType.Magic,"magic" },
			{ IconType.Truck,"truck" },
			{ IconType.Pinterest,"pinterest" },
			{ IconType.PinterestSign,"pinterest-sign" },
			{ IconType.GooglePlusSign,"google-plus-sign" },
			{ IconType.GooglePlus,"google-plus" },
			{ IconType.Money,"money" },
			{ IconType.CaretDown,"caret-down" },
			{ IconType.CaretUp,"caret-up" },
			{ IconType.CaretLeft,"caret-left" },
			{ IconType.CaretRight,"caret-right" },
			{ IconType.Columns,"columns" },
			{ IconType.Sort,"sort" },
			{ IconType.SortDown,"sort-down" },
			{ IconType.SortUp,"sort-up" },
			{ IconType.Envelope,"envelope" },
			{ IconType.Linkedin,"linkedin" },
			{ IconType.Undo,"undo" },
			{ IconType.Legal,"legal" },
			{ IconType.Dashboard,"dashboard" },
			{ IconType.CommentAlt,"comment-alt" },
			{ IconType.CommentsAlt,"comments-alt" },
			{ IconType.Bolt,"bolt" },
			{ IconType.Sitemap,"sitemap" },
			{ IconType.Umbrella,"umbrella" },
			{ IconType.Paste,"paste" },
			{ IconType.Lightbulb,"lightbulb" },
			{ IconType.Exchange,"exchange" },
			{ IconType.CloudDownload,"cloud-download" },
			{ IconType.CloudUpload,"cloud-upload" },
			{ IconType.UserMd,"user-md" },
			{ IconType.Stethoscope,"stethoscope" },
			{ IconType.Suitcase,"suitcase" },
			{ IconType.BellAlt,"bell-alt" },
			{ IconType.Coffee,"coffee" },
			{ IconType.Food,"food" },
			{ IconType.FileTextAlt,"file-text-alt" },
			{ IconType.Building,"building" },
			{ IconType.Hospital,"hospital" },
			{ IconType.Ambulance,"ambulance" },
			{ IconType.Medkit,"medkit" },
			{ IconType.FighterJet,"fighter-jet" },
			{ IconType.Beer,"beer" },
			{ IconType.HSign,"h-sign" },
			{ IconType.PlusSignAlt,"plus-sign-alt" },
			{ IconType.DoubleAngleLeft,"double-angle-left" },
			{ IconType.DoubleAngleRight,"double-angle-right" },
			{ IconType.DoubleAngleUp,"double-angle-up" },
			{ IconType.DoubleAngleDown,"double-angle-down" },
			{ IconType.AngleLeft,"angle-left" },
			{ IconType.AngleRight,"angle-right" },
			{ IconType.AngleUp,"angle-up" },
			{ IconType.AngleDown,"angle-down" },
			{ IconType.Desktop,"desktop" },
			{ IconType.Laptop,"laptop" },
			{ IconType.Tablet,"tablet" },
			{ IconType.MobilePhone,"mobile-phone" },
			{ IconType.CircleBlank,"circle-blank" },
			{ IconType.QuoteLeft,"quote-left" },
			{ IconType.QuoteRight,"quote-right" },
			{ IconType.Spinner,"spinner" },
			{ IconType.Circle,"circle" },
			{ IconType.Reply,"reply" },
			{ IconType.GithubAlt,"github-alt" },
			{ IconType.FolderCloseAlt,"folder-close-alt" },
			{ IconType.FolderOpenAlt,"folder-open-alt" },
			{ IconType.ExpandAlt,"expand-alt" },
			{ IconType.CollapseAlt,"collapse-alt" },
			{ IconType.Smile,"smile" },
			{ IconType.Frown,"frown" },
			{ IconType.Meh,"meh" },
			{ IconType.Gamepad,"gamepad" },
			{ IconType.Keyboard,"keyboard" },
			{ IconType.FlagAlt,"flag-alt" },
			{ IconType.FlagCheckered,"flag-checkered" },
			{ IconType.Terminal,"terminal" },
			{ IconType.Code,"code" },
			{ IconType.ReplyAll,"reply-all" },
			{ IconType.MailReplyAll,"mail-reply-all" },
			{ IconType.StarHalfEmpty,"star-half-empty" },
			{ IconType.LocationArrow,"location-arrow" },
			{ IconType.Crop,"crop" },
			{ IconType.CodeFork,"code-fork" },
			{ IconType.Unlink,"unlink" },
			{ IconType.Question,"question" },
			{ IconType.Info,"info" },
			{ IconType.Exclamation,"exclamation" },
			{ IconType.Superscript,"superscript" },
			{ IconType.Subscript,"subscript" },
			{ IconType.Eraser,"eraser" },
			{ IconType.PuzzlePiece,"puzzle-piece" },
			{ IconType.Microphone,"microphone" },
			{ IconType.MicrophoneOff,"microphone-off" },
			{ IconType.Shield,"shield" },
			{ IconType.CalendarEmpty,"calendar-empty" },
			{ IconType.FireExtinguisher,"fire-extinguisher" },
			{ IconType.Rocket,"rocket" },
			{ IconType.Maxcdn,"maxcdn" },
			{ IconType.ChevronSignLeft,"chevron-sign-left" },
			{ IconType.ChevronSignRight,"chevron-sign-right" },
			{ IconType.ChevronSignUp,"chevron-sign-up" },
			{ IconType.ChevronSignDown,"chevron-sign-down" },
			{ IconType.Html5Logo,"html5" },
			{ IconType.Css3Logo,"css3" },
			{ IconType.Anchor,"anchor" },
			{ IconType.UnlockAlt,"unlock-alt" },
			{ IconType.Bullseye,"bullseye" },
			{ IconType.HorizontalEllipsis,"ellipsis-horizontal" },
			{ IconType.VerticalEllipsis,"ellipsis-vertical" },
			{ IconType.RssSign,"rss-sign" },
			{ IconType.PlaySign,"play-sign" },
			{ IconType.Ticket,"ticket" },
			{ IconType.MinusSignAlt,"minus-sign-alt" },
			{ IconType.CheckMinus,"check-minus" },
			{ IconType.LevelUp,"level-up" },
			{ IconType.LevelDown,"level-down" },
			{ IconType.CheckSign,"check-sign" },
			{ IconType.EditSign,"edit-sign" },
			{ IconType.ExteralLinkSign,"external-link-sign" },
			{ IconType.ShareSign,"share-sign" },
			{ IconType.Compass,"compass" },
			{ IconType.Collapse,"collapse" },
			{ IconType.CollapseTop,"collapse-top" },
			{ IconType.Expand,"expand" },
			{ IconType.Euro,"eur" },
			{ IconType.Gbp,"gbp" },
			{ IconType.UsDollar,"usd" },
			{ IconType.IndianRupee,"inr" },
			{ IconType.JapaneseYen,"jpy" },
			{ IconType.Renminbi,"cny" },
			{ IconType.KoreanWon,"krw" },
			{ IconType.Bitcoin,"btc" },
			{ IconType.File,"file" },
			{ IconType.FileText,"file-text" },
			{ IconType.SortByAlphabet,"sort-by-alphabet" },
			{ IconType.SortByAlphabetAlt,"sort-by-alphabet-alt" },
			{ IconType.SortByAttributes,"sort-by-attributes" },
			{ IconType.SortByAttributesAlt,"sort-by-attributes-alt" },
			{ IconType.SortByOrder,"sort-by-order" },
			{ IconType.SortByOrderAlt,"sort-by-order-alt" },
			{ IconType.ThumbsUp,"thumbs-up" },
			{ IconType.ThumbsDown,"thumbs-down" },
			{ IconType.YoutubeSign,"youtube-sign" },
			{ IconType.Youtube,"youtube" },
			{ IconType.Xing,"xing" },
			{ IconType.XingSign,"xing-sign" },
			{ IconType.YoutubePlay,"youtube-play" },
			{ IconType.Dropbox,"dropbox" },
			{ IconType.StackExchange,"stackexchange" },
			{ IconType.Instagram,"instagram" },
			{ IconType.Flickr,"flickr" },
			{ IconType.AppNet,"adn" },
			{ IconType.Bitbucket,"bitbucket" },
			{ IconType.BitbucketSign,"bitbucket-sign" },
			{ IconType.Tumblr,"tumblr" },
			{ IconType.TumblrSign,"tumblr-sign" },
			{ IconType.LongArrowDown,"long-arrow-down" },
			{ IconType.LongArrowUp,"long-arrow-up" },
			{ IconType.LongArrowLeft,"long-arrow-left" },
			{ IconType.LongArrowRight,"long-arrow-right" },
			{ IconType.Apple,"apple" },
			{ IconType.Windows,"windows" },
			{ IconType.Android,"android" },
			{ IconType.Linux,"linux" },
			{ IconType.Dribbble,"dribbble" },
			{ IconType.Skype,"skype" },
			{ IconType.Foursquare,"foursquare" },
			{ IconType.Trello,"trello" },
			{ IconType.Female,"female" },
			{ IconType.Male,"male" },
			{ IconType.Gittip,"gittip" },
			{ IconType.Sun,"sun" },
			{ IconType.Moon,"moon" },
			{ IconType.Archive,"archive" },
			{ IconType.Bug,"bug" },
			{ IconType.Vk,"vk" },
			{ IconType.Weibo,"weibo" },
			{ IconType.Renren,"renren" },
		};


		public static Dictionary<AppearanceType, string> ButtonAppearanceCssMap = new Dictionary<AppearanceType, string>() { 
			{ AppearanceType.Default, "btn-default" },
			{ AppearanceType.Primary, "btn-primary" },
			{ AppearanceType.Success, "btn-success" },
			{ AppearanceType.Info, "btn-info" },
			{ AppearanceType.Warning, "btn-warning" },
			{ AppearanceType.Danger, "btn-danger" }
		};

		public static Dictionary<ButtonSize, string> ButtonSizeCssMap = new Dictionary<ButtonSize, string>() { 
			{ ButtonSize.Default, string.Empty },
			{ ButtonSize.Small, "btn-sm" },
			{ ButtonSize.ExtraSmall, "btn-xs" },
			{ ButtonSize.Large, "btn-lg" }
		};

		public static Dictionary<ButtonSize, string> ButtonGroupSizeCssMap = new Dictionary<ButtonSize, string>() { 
			{ ButtonSize.Default, string.Empty },
			{ ButtonSize.Small, "btn-group-sm" },
			{ ButtonSize.ExtraSmall, "btn-group-xs" },
			{ ButtonSize.Large, "btn-group-lg" }
		};

		public static Dictionary<IconRotation, string> IconRotationCssMap = new Dictionary<IconRotation, string>() { 
			{ IconRotation.Default, string.Empty },
			{ IconRotation.Rotate90, "icon-rotate-90" },
			{ IconRotation.Rotate180, "icon-rotate-180" },
			{ IconRotation.Rotate270, "icon-rotate-270" },
			{ IconRotation.FlipHorizontal, "icon-flip-horizontal" },
			{ IconRotation.FlipVertical, "icon-flip-vertical" }
		};

		public static Dictionary<IconSize, string> IconSizeCssMap = new Dictionary<IconSize, string>() { 
			{ IconSize.Default, string.Empty },
			{ IconSize.Large, "icon-large" },
			{ IconSize.x2, "icon-2x" },
			{ IconSize.x3, "icon-3x" },
			{ IconSize.x4, "icon-4x" }
		};
		public static Dictionary<AppearanceType, string> LabelAppearanceCssMap = new Dictionary<AppearanceType, string>() { 
			{ AppearanceType.Default, "label-default" },
			{ AppearanceType.Primary, "label-primary" },
			{ AppearanceType.Success, "label-success" },
			{ AppearanceType.Info, "label-info" },
			{ AppearanceType.Warning, "label-warning" },
			{ AppearanceType.Danger, "label-danger" }
		};

		public static Dictionary<AppearanceType, string> ProgressBarAppearanceCssMap = new Dictionary<AppearanceType, string>() { 
			{ AppearanceType.Default, "progress-bar-success" },
			{ AppearanceType.Primary, "progress-bar-success" },
			{ AppearanceType.Success, "progress-bar-success" },
			{ AppearanceType.Info, "progress-bar-info" },
			{ AppearanceType.Warning, "progress-bar-warning" },
			{ AppearanceType.Danger, "progress-bar-danger" }
		};

		public static Dictionary<WellSize, string> WellSizeCssMap = new Dictionary<WellSize, string>() { 
			{ WellSize.Default, "" },
			{ WellSize.Small, "well-sm" },
			{ WellSize.Large, "well-lg" },
			
		};

		public static Dictionary<AppearanceType, string> AlertAppearanceCssMap = new Dictionary<AppearanceType, string>() { 
			{ AppearanceType.Default, "alert-success" },
			{ AppearanceType.Primary, "alert-success" },
			{ AppearanceType.Success, "alert-success" },
			{ AppearanceType.Info, "alert-info" },
			{ AppearanceType.Warning, "alert-warning" },
			{ AppearanceType.Danger, "alert-danger" }
			
		};

		public static Dictionary<PagerSize, string> PagerSizeCssMap = new Dictionary<PagerSize, string>() { 
			{ PagerSize.Default, "" },
			{ PagerSize.Small, "pagination-sm" },
			{ PagerSize.Large, "pagination-lg" },
			
		};

		public static Dictionary<NavType, string> NavTypeCssMap = new Dictionary<NavType, string>() { 
			{ NavType.Tabs, "nav-tabs" },
			{ NavType.Pills, "nav-pills" },
			{ NavType.PillsStacked, "nav-pills nav-stacked" },
		};

        public static Dictionary<AppearanceType, string> SelectStyleCssMap = new Dictionary<AppearanceType, string>() { 
			{ AppearanceType.Primary, "btn-primary" },
			{ AppearanceType.Info, "btn-info" },
            { AppearanceType.Success, "btn-success" },
            { AppearanceType.Warning, "btn-warning" },
            { AppearanceType.Danger, "btn-danger" },
            { AppearanceType.Default, "" }
			
		};

	}
}