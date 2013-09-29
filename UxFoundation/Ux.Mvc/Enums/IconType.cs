﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ux.Mvc.Web.UI
{
	/// <summary>
	/// List of all FontAwesome 3.2.1 icons.
	/// </summary>
	public enum IconType
	{
		// If FontAwesome needs to be upgraded:
		// Obtain the YAML file from FontAwesomes Github account
		// Convert the YAML into JSON http://yaml-online-parser.appspot.com/
		// Copy the JSON data into http://jsfiddle.net/7dahS/ and run the script
		// This will give you a list of all the different icon names.
		// You'll need to remove spaces and enforce capitalisation - I did this in Excel, it's faster.
		// You can also refactor the fiddle to show "id" instead of name. This is the css class
		Glass,
		Music,
		Search,
		EnvelopeAlt,
		Heart,
		Star,
		StarEmpty,
		User,
		Film,
		ThLarge,
		Th,
		ThList,
		Ok,
		Remove,
		ZoomIn,
		ZoomOut,
		Off,
		Signal,
		Cog,
		Trash,
		Home,
		FileAlt,
		Time,
		Road,
		DownloadAlt,
		Download,
		Upload,
		Inbox,
		PlayCircle,
		Repeat,
		Refresh,
		ListAlt,
		Lock,
		Flag,
		Headphones,
		VolumeOff,
		VolumeDown,
		VolumeUp,
		Qrcode,
		Barcode,
		Tag,
		Tags,
		Book,
		Bookmark,
		Print,
		Camera,
		Font,
		Bold,
		Italic,
		TextHeight,
		TextWidth,
		AlignLeft,
		AlignCenter,
		AlignRight,
		AlignJustify,
		List,
		IndentLeft,
		IndentRight,
		FacetimeVideo,
		Picture,
		Pencil,
		MapMarker,
		Adjust,
		Tint,
		Edit,
		Share,
		Check,
		Move,
		StepBackward,
		FastBackward,
		Backward,
		Play,
		Pause,
		Stop,
		Forward,
		FastForward,
		StepForward,
		Eject,
		ChevronLeft,
		ChevronRight,
		PlusSign,
		MinusSign,
		RemoveSign,
		OkSign,
		QuestionSign,
		InfoSign,
		Screenshot,
		RemoveCircle,
		OkCircle,
		BanCircle,
		ArrowLeft,
		ArrowRight,
		ArrowUp,
		ArrowDown,
		ShareAlt,
		ResizeFull,
		ResizeSmall,
		Plus,
		Minus,
		Asterisk,
		ExclamationSign,
		Gift,
		Leaf,
		Fire,
		EyeOpen,
		EyeClose,
		WarningSign,
		Plane,
		Calendar,
		Random,
		Comment,
		Magnet,
		ChevronUp,
		ChevronDown,
		Retweet,
		ShoppingCart,
		FolderClose,
		FolderOpen,
		ResizeVertical,
		ResizeHorizontal,
		BarChart,
		TwitterSign,
		FacebookSign,
		CameraRetro,
		Key,
		Cogs,
		Comments,
		ThumbsUpAlt,
		ThumbsDownAlt,
		StarHalf,
		HeartEmpty,
		Signout,
		LinkedinSign,
		Pushpin,
		ExternalLink,
		Signin,
		Trophy,
		GithubSign,
		UploadAlt,
		Lemon,
		Phone,
		CheckEmpty,
		BookmarkEmpty,
		PhoneSign,
		Twitter,
		Facebook,
		Github,
		Unlock,
		CreditCard,
		Rss,
		Hdd,
		Bullhorn,
		Bell,
		Certificate,
		HandRight,
		HandLeft,
		HandUp,
		HandDown,
		CircleArrowLeft,
		CircleArrowRight,
		CircleArrowUp,
		CircleArrowDown,
		Globe,
		Wrench,
		Tasks,
		Filter,
		Briefcase,
		Fullscreen,
		Group,
		Link,
		Cloud,
		Beaker,
		Cut,
		Copy,
		PaperClip,
		Save,
		SignBlank,
		Reorder,
		ListUl,
		ListOl,
		Strikethrough,
		Underline,
		Table,
		Magic,
		Truck,
		Pinterest,
		PinterestSign,
		GooglePlusSign,
		GooglePlus,
		Money,
		CaretDown,
		CaretUp,
		CaretLeft,
		CaretRight,
		Columns,
		Sort,
		SortDown,
		SortUp,
		Envelope,
		Linkedin,
		Undo,
		Legal,
		Dashboard,
		CommentAlt,
		CommentsAlt,
		Bolt,
		Sitemap,
		Umbrella,
		Paste,
		Lightbulb,
		Exchange,
		CloudDownload,
		CloudUpload,
		UserMd,
		Stethoscope,
		Suitcase,
		BellAlt,
		Coffee,
		Food,
		FileTextAlt,
		Building,
		Hospital,
		Ambulance,
		Medkit,
		FighterJet,
		Beer,
		HSign,
		PlusSignAlt,
		DoubleAngleLeft,
		DoubleAngleRight,
		DoubleAngleUp,
		DoubleAngleDown,
		AngleLeft,
		AngleRight,
		AngleUp,
		AngleDown,
		Desktop,
		Laptop,
		Tablet,
		MobilePhone,
		CircleBlank,
		QuoteLeft,
		QuoteRight,
		Spinner,
		Circle,
		Reply,
		GithubAlt,
		FolderCloseAlt,
		FolderOpenAlt,
		ExpandAlt,
		CollapseAlt,
		Smile,
		Frown,
		Meh,
		Gamepad,
		Keyboard,
		FlagAlt,
		FlagCheckered,
		Terminal,
		Code,
		ReplyAll,
		MailReplyAll,
		StarHalfEmpty,
		LocationArrow,
		Crop,
		CodeFork,
		Unlink,
		Question,
		Info,
		Exclamation,
		Superscript,
		Subscript,
		Eraser,
		PuzzlePiece,
		Microphone,
		MicrophoneOff,
		Shield,
		CalendarEmpty,
		FireExtinguisher,
		Rocket,
		Maxcdn,
		ChevronSignLeft,
		ChevronSignRight,
		ChevronSignUp,
		ChevronSignDown,
		Html5Logo,
		Css3Logo,
		Anchor,
		UnlockAlt,
		Bullseye,
		HorizontalEllipsis,
		VerticalEllipsis,
		RssSign,
		PlaySign,
		Ticket,
		MinusSignAlt,
		CheckMinus,
		LevelUp,
		LevelDown,
		CheckSign,
		EditSign,
		ExteralLinkSign,
		ShareSign,
		Compass,
		Collapse,
		CollapseTop,
		Expand,
		Euro,
		Gbp,
		UsDollar,
		IndianRupee,
		JapaneseYen,
		Renminbi,
		KoreanWon,
		Bitcoin,
		File,
		FileText,
		SortByAlphabet,
		SortByAlphabetAlt,
		SortByAttributes,
		SortByAttributesAlt,
		SortByOrder,
		SortByOrderAlt,
		ThumbsUp,
		ThumbsDown,
		YoutubeSign,
		Youtube,
		Xing,
		XingSign,
		YoutubePlay,
		Dropbox,
		StackExchange,
		Instagram,
		Flickr,
		AppNet,
		Bitbucket,
		BitbucketSign,
		Tumblr,
		TumblrSign,
		LongArrowDown,
		LongArrowUp,
		LongArrowLeft,
		LongArrowRight,
		Apple,
		Windows,
		Android,
		Linux,
		Dribbble,
		Skype,
		Foursquare,
		Trello,
		Female,
		Male,
		Gittip,
		Sun,
		Moon,
		Archive,
		Bug,
		Vk,
		Weibo,
		Renren
	}
}