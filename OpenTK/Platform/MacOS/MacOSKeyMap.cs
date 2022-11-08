﻿using System;
using OpenTK.Input;

namespace OpenTK.Platform.MacOS
{
	// Token: 0x0200007A RID: 122
	internal static class MacOSKeyMap
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x00018C34 File Offset: 0x00016E34
		public static Key GetKey(MacOSKeyCode code)
		{
			switch (code)
			{
			case MacOSKeyCode.A:
				return Key.A;
			case MacOSKeyCode.S:
				return Key.S;
			case MacOSKeyCode.D:
				return Key.D;
			case MacOSKeyCode.F:
				return Key.F;
			case MacOSKeyCode.H:
				return Key.H;
			case MacOSKeyCode.G:
				return Key.G;
			case MacOSKeyCode.Z:
				return Key.Z;
			case MacOSKeyCode.X:
				return Key.X;
			case MacOSKeyCode.C:
				return Key.C;
			case MacOSKeyCode.V:
				return Key.V;
			case MacOSKeyCode.B:
				return Key.B;
			case MacOSKeyCode.Q:
				return Key.Q;
			case MacOSKeyCode.W:
				return Key.W;
			case MacOSKeyCode.E:
				return Key.E;
			case MacOSKeyCode.R:
				return Key.R;
			case MacOSKeyCode.Y:
				return Key.Y;
			case MacOSKeyCode.T:
				return Key.T;
			case MacOSKeyCode.Key_1:
				return Key.Number1;
			case MacOSKeyCode.Key_2:
				return Key.Number2;
			case MacOSKeyCode.Key_3:
				return Key.Number3;
			case MacOSKeyCode.Key_4:
				return Key.Number4;
			case MacOSKeyCode.Key_6:
				return Key.Number6;
			case MacOSKeyCode.Key_5:
				return Key.Number5;
			case MacOSKeyCode.Equals:
				return Key.Plus;
			case MacOSKeyCode.Key_9:
				return Key.Number9;
			case MacOSKeyCode.Key_7:
				return Key.Number7;
			case MacOSKeyCode.Minus:
				return Key.Minus;
			case MacOSKeyCode.Key_8:
				return Key.Number8;
			case MacOSKeyCode.Key_0:
				return Key.Number0;
			case MacOSKeyCode.BracketRight:
				return Key.BracketRight;
			case MacOSKeyCode.O:
				return Key.O;
			case MacOSKeyCode.U:
				return Key.U;
			case MacOSKeyCode.BracketLeft:
				return Key.BracketLeft;
			case MacOSKeyCode.I:
				return Key.I;
			case MacOSKeyCode.P:
				return Key.P;
			case MacOSKeyCode.Enter:
				return Key.Enter;
			case MacOSKeyCode.L:
				return Key.L;
			case MacOSKeyCode.J:
				return Key.J;
			case MacOSKeyCode.Quote:
				return Key.Quote;
			case MacOSKeyCode.K:
				return Key.K;
			case MacOSKeyCode.Semicolon:
				return Key.Semicolon;
			case MacOSKeyCode.Backslash:
				return Key.BackSlash;
			case MacOSKeyCode.Comma:
				return Key.Comma;
			case MacOSKeyCode.Slash:
				return Key.Slash;
			case MacOSKeyCode.N:
				return Key.N;
			case MacOSKeyCode.M:
				return Key.M;
			case MacOSKeyCode.Period:
				return Key.Period;
			case MacOSKeyCode.Tab:
				return Key.Tab;
			case MacOSKeyCode.Space:
				return Key.Space;
			case MacOSKeyCode.Tilde:
				return Key.Tilde;
			case MacOSKeyCode.Backspace:
				return Key.BackSpace;
			case MacOSKeyCode.Return:
				return Key.Enter;
			case MacOSKeyCode.Esc:
				return Key.Escape;
			case MacOSKeyCode.Command:
				return Key.WinLeft;
			case MacOSKeyCode.Shift:
				return Key.ShiftLeft;
			case MacOSKeyCode.OptionAlt:
				return Key.AltLeft;
			case MacOSKeyCode.Control:
				return Key.ControlLeft;
			case MacOSKeyCode.KeyPad_Decimal:
				return Key.KeypadDecimal;
			case MacOSKeyCode.KeyPad_Multiply:
				return Key.KeypadMultiply;
			case MacOSKeyCode.KeyPad_Add:
				return Key.KeypadAdd;
			case MacOSKeyCode.KeyPad_Divide:
				return Key.KeypadDivide;
			case MacOSKeyCode.KeyPad_Enter:
				return Key.KeypadEnter;
			case MacOSKeyCode.KeyPad_Subtract:
				return Key.KeypadSubtract;
			case MacOSKeyCode.KeyPad_0:
				return Key.Keypad0;
			case MacOSKeyCode.KeyPad_1:
				return Key.Keypad1;
			case MacOSKeyCode.KeyPad_2:
				return Key.Keypad2;
			case MacOSKeyCode.KeyPad_3:
				return Key.Keypad3;
			case MacOSKeyCode.KeyPad_4:
				return Key.Keypad4;
			case MacOSKeyCode.KeyPad_5:
				return Key.Keypad5;
			case MacOSKeyCode.KeyPad_6:
				return Key.Keypad6;
			case MacOSKeyCode.KeyPad_7:
				return Key.Keypad7;
			case MacOSKeyCode.KeyPad_8:
				return Key.Keypad8;
			case MacOSKeyCode.KeyPad_9:
				return Key.Keypad9;
			case MacOSKeyCode.F5:
				return Key.F5;
			case MacOSKeyCode.F6:
				return Key.F6;
			case MacOSKeyCode.F7:
				return Key.F7;
			case MacOSKeyCode.F3:
				return Key.F3;
			case MacOSKeyCode.F8:
				return Key.F8;
			case MacOSKeyCode.F9:
				return Key.F9;
			case MacOSKeyCode.F11:
				return Key.F11;
			case MacOSKeyCode.F13:
				return Key.F13;
			case MacOSKeyCode.F14:
				return Key.F14;
			case MacOSKeyCode.F10:
				return Key.F10;
			case MacOSKeyCode.Menu:
				return Key.Menu;
			case MacOSKeyCode.F12:
				return Key.F12;
			case MacOSKeyCode.F15:
				return Key.F15;
			case MacOSKeyCode.Insert:
				return Key.Insert;
			case MacOSKeyCode.Home:
				return Key.Home;
			case MacOSKeyCode.Pageup:
				return Key.PageUp;
			case MacOSKeyCode.Del:
				return Key.Delete;
			case MacOSKeyCode.F4:
				return Key.F4;
			case MacOSKeyCode.End:
				return Key.End;
			case MacOSKeyCode.F2:
				return Key.F2;
			case MacOSKeyCode.Pagedown:
				return Key.PageDown;
			case MacOSKeyCode.F1:
				return Key.F1;
			case MacOSKeyCode.Left:
				return Key.Left;
			case MacOSKeyCode.Right:
				return Key.Right;
			case MacOSKeyCode.Down:
				return Key.Down;
			case MacOSKeyCode.Up:
				return Key.Up;
			}
			return Key.Unknown;
		}
	}
}
