﻿using System;

namespace OpenTK.Platform.X11
{
	// Token: 0x02000166 RID: 358
	internal enum AtomName
	{
		// Token: 0x04000E86 RID: 3718
		AnyPropertyType,
		// Token: 0x04000E87 RID: 3719
		XA_PRIMARY,
		// Token: 0x04000E88 RID: 3720
		XA_SECONDARY,
		// Token: 0x04000E89 RID: 3721
		XA_ARC,
		// Token: 0x04000E8A RID: 3722
		XA_ATOM,
		// Token: 0x04000E8B RID: 3723
		XA_BITMAP,
		// Token: 0x04000E8C RID: 3724
		XA_CARDINAL,
		// Token: 0x04000E8D RID: 3725
		XA_COLORMAP,
		// Token: 0x04000E8E RID: 3726
		XA_CURSOR,
		// Token: 0x04000E8F RID: 3727
		XA_CUT_BUFFER0,
		// Token: 0x04000E90 RID: 3728
		XA_CUT_BUFFER1,
		// Token: 0x04000E91 RID: 3729
		XA_CUT_BUFFER2,
		// Token: 0x04000E92 RID: 3730
		XA_CUT_BUFFER3,
		// Token: 0x04000E93 RID: 3731
		XA_CUT_BUFFER4,
		// Token: 0x04000E94 RID: 3732
		XA_CUT_BUFFER5,
		// Token: 0x04000E95 RID: 3733
		XA_CUT_BUFFER6,
		// Token: 0x04000E96 RID: 3734
		XA_CUT_BUFFER7,
		// Token: 0x04000E97 RID: 3735
		XA_DRAWABLE,
		// Token: 0x04000E98 RID: 3736
		XA_FONT,
		// Token: 0x04000E99 RID: 3737
		XA_INTEGER,
		// Token: 0x04000E9A RID: 3738
		XA_PIXMAP,
		// Token: 0x04000E9B RID: 3739
		XA_POINT,
		// Token: 0x04000E9C RID: 3740
		XA_RECTANGLE,
		// Token: 0x04000E9D RID: 3741
		XA_RESOURCE_MANAGER,
		// Token: 0x04000E9E RID: 3742
		XA_RGB_COLOR_MAP,
		// Token: 0x04000E9F RID: 3743
		XA_RGB_BEST_MAP,
		// Token: 0x04000EA0 RID: 3744
		XA_RGB_BLUE_MAP,
		// Token: 0x04000EA1 RID: 3745
		XA_RGB_DEFAULT_MAP,
		// Token: 0x04000EA2 RID: 3746
		XA_RGB_GRAY_MAP,
		// Token: 0x04000EA3 RID: 3747
		XA_RGB_GREEN_MAP,
		// Token: 0x04000EA4 RID: 3748
		XA_RGB_RED_MAP,
		// Token: 0x04000EA5 RID: 3749
		XA_STRING,
		// Token: 0x04000EA6 RID: 3750
		XA_VISUALID,
		// Token: 0x04000EA7 RID: 3751
		XA_WINDOW,
		// Token: 0x04000EA8 RID: 3752
		XA_WM_COMMAND,
		// Token: 0x04000EA9 RID: 3753
		XA_WM_HINTS,
		// Token: 0x04000EAA RID: 3754
		XA_WM_CLIENT_MACHINE,
		// Token: 0x04000EAB RID: 3755
		XA_WM_ICON_NAME,
		// Token: 0x04000EAC RID: 3756
		XA_WM_ICON_SIZE,
		// Token: 0x04000EAD RID: 3757
		XA_WM_NAME,
		// Token: 0x04000EAE RID: 3758
		XA_WM_NORMAL_HINTS,
		// Token: 0x04000EAF RID: 3759
		XA_WM_SIZE_HINTS,
		// Token: 0x04000EB0 RID: 3760
		XA_WM_ZOOM_HINTS,
		// Token: 0x04000EB1 RID: 3761
		XA_MIN_SPACE,
		// Token: 0x04000EB2 RID: 3762
		XA_NORM_SPACE,
		// Token: 0x04000EB3 RID: 3763
		XA_MAX_SPACE,
		// Token: 0x04000EB4 RID: 3764
		XA_END_SPACE,
		// Token: 0x04000EB5 RID: 3765
		XA_SUPERSCRIPT_X,
		// Token: 0x04000EB6 RID: 3766
		XA_SUPERSCRIPT_Y,
		// Token: 0x04000EB7 RID: 3767
		XA_SUBSCRIPT_X,
		// Token: 0x04000EB8 RID: 3768
		XA_SUBSCRIPT_Y,
		// Token: 0x04000EB9 RID: 3769
		XA_UNDERLINE_POSITION,
		// Token: 0x04000EBA RID: 3770
		XA_UNDERLINE_THICKNESS,
		// Token: 0x04000EBB RID: 3771
		XA_STRIKEOUT_ASCENT,
		// Token: 0x04000EBC RID: 3772
		XA_STRIKEOUT_DESCENT,
		// Token: 0x04000EBD RID: 3773
		XA_ITALIC_ANGLE,
		// Token: 0x04000EBE RID: 3774
		XA_X_HEIGHT,
		// Token: 0x04000EBF RID: 3775
		XA_QUAD_WIDTH,
		// Token: 0x04000EC0 RID: 3776
		XA_WEIGHT,
		// Token: 0x04000EC1 RID: 3777
		XA_POINT_SIZE,
		// Token: 0x04000EC2 RID: 3778
		XA_RESOLUTION,
		// Token: 0x04000EC3 RID: 3779
		XA_COPYRIGHT,
		// Token: 0x04000EC4 RID: 3780
		XA_NOTICE,
		// Token: 0x04000EC5 RID: 3781
		XA_FONT_NAME,
		// Token: 0x04000EC6 RID: 3782
		XA_FAMILY_NAME,
		// Token: 0x04000EC7 RID: 3783
		XA_FULL_NAME,
		// Token: 0x04000EC8 RID: 3784
		XA_CAP_HEIGHT,
		// Token: 0x04000EC9 RID: 3785
		XA_WM_CLASS,
		// Token: 0x04000ECA RID: 3786
		XA_WM_TRANSIENT_FOR,
		// Token: 0x04000ECB RID: 3787
		XA_LAST_PREDEFINED = 68
	}
}
