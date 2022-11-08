﻿using System;

namespace OpenTK.Platform.Windows
{
	// Token: 0x020000BE RID: 190
	internal enum VirtualKeys : short
	{
		// Token: 0x040004D1 RID: 1233
		LBUTTON = 1,
		// Token: 0x040004D2 RID: 1234
		RBUTTON,
		// Token: 0x040004D3 RID: 1235
		CANCEL,
		// Token: 0x040004D4 RID: 1236
		MBUTTON,
		// Token: 0x040004D5 RID: 1237
		XBUTTON1,
		// Token: 0x040004D6 RID: 1238
		XBUTTON2,
		// Token: 0x040004D7 RID: 1239
		BACK = 8,
		// Token: 0x040004D8 RID: 1240
		TAB,
		// Token: 0x040004D9 RID: 1241
		CLEAR = 12,
		// Token: 0x040004DA RID: 1242
		RETURN,
		// Token: 0x040004DB RID: 1243
		SHIFT = 16,
		// Token: 0x040004DC RID: 1244
		CONTROL,
		// Token: 0x040004DD RID: 1245
		MENU,
		// Token: 0x040004DE RID: 1246
		PAUSE,
		// Token: 0x040004DF RID: 1247
		CAPITAL,
		// Token: 0x040004E0 RID: 1248
		KANA,
		// Token: 0x040004E1 RID: 1249
		HANGEUL = 21,
		// Token: 0x040004E2 RID: 1250
		HANGUL = 21,
		// Token: 0x040004E3 RID: 1251
		JUNJA = 23,
		// Token: 0x040004E4 RID: 1252
		FINAL,
		// Token: 0x040004E5 RID: 1253
		HANJA,
		// Token: 0x040004E6 RID: 1254
		KANJI = 25,
		// Token: 0x040004E7 RID: 1255
		ESCAPE = 27,
		// Token: 0x040004E8 RID: 1256
		CONVERT,
		// Token: 0x040004E9 RID: 1257
		NONCONVERT,
		// Token: 0x040004EA RID: 1258
		ACCEPT,
		// Token: 0x040004EB RID: 1259
		MODECHANGE,
		// Token: 0x040004EC RID: 1260
		SPACE,
		// Token: 0x040004ED RID: 1261
		PRIOR,
		// Token: 0x040004EE RID: 1262
		NEXT,
		// Token: 0x040004EF RID: 1263
		END,
		// Token: 0x040004F0 RID: 1264
		HOME,
		// Token: 0x040004F1 RID: 1265
		LEFT,
		// Token: 0x040004F2 RID: 1266
		UP,
		// Token: 0x040004F3 RID: 1267
		RIGHT,
		// Token: 0x040004F4 RID: 1268
		DOWN,
		// Token: 0x040004F5 RID: 1269
		SELECT,
		// Token: 0x040004F6 RID: 1270
		PRINT,
		// Token: 0x040004F7 RID: 1271
		EXECUTE,
		// Token: 0x040004F8 RID: 1272
		SNAPSHOT,
		// Token: 0x040004F9 RID: 1273
		INSERT,
		// Token: 0x040004FA RID: 1274
		DELETE,
		// Token: 0x040004FB RID: 1275
		HELP,
		// Token: 0x040004FC RID: 1276
		LWIN = 91,
		// Token: 0x040004FD RID: 1277
		RWIN,
		// Token: 0x040004FE RID: 1278
		APPS,
		// Token: 0x040004FF RID: 1279
		SLEEP = 95,
		// Token: 0x04000500 RID: 1280
		NUMPAD0,
		// Token: 0x04000501 RID: 1281
		NUMPAD1,
		// Token: 0x04000502 RID: 1282
		NUMPAD2,
		// Token: 0x04000503 RID: 1283
		NUMPAD3,
		// Token: 0x04000504 RID: 1284
		NUMPAD4,
		// Token: 0x04000505 RID: 1285
		NUMPAD5,
		// Token: 0x04000506 RID: 1286
		NUMPAD6,
		// Token: 0x04000507 RID: 1287
		NUMPAD7,
		// Token: 0x04000508 RID: 1288
		NUMPAD8,
		// Token: 0x04000509 RID: 1289
		NUMPAD9,
		// Token: 0x0400050A RID: 1290
		MULTIPLY,
		// Token: 0x0400050B RID: 1291
		ADD,
		// Token: 0x0400050C RID: 1292
		SEPARATOR,
		// Token: 0x0400050D RID: 1293
		SUBTRACT,
		// Token: 0x0400050E RID: 1294
		DECIMAL,
		// Token: 0x0400050F RID: 1295
		DIVIDE,
		// Token: 0x04000510 RID: 1296
		F1,
		// Token: 0x04000511 RID: 1297
		F2,
		// Token: 0x04000512 RID: 1298
		F3,
		// Token: 0x04000513 RID: 1299
		F4,
		// Token: 0x04000514 RID: 1300
		F5,
		// Token: 0x04000515 RID: 1301
		F6,
		// Token: 0x04000516 RID: 1302
		F7,
		// Token: 0x04000517 RID: 1303
		F8,
		// Token: 0x04000518 RID: 1304
		F9,
		// Token: 0x04000519 RID: 1305
		F10,
		// Token: 0x0400051A RID: 1306
		F11,
		// Token: 0x0400051B RID: 1307
		F12,
		// Token: 0x0400051C RID: 1308
		F13,
		// Token: 0x0400051D RID: 1309
		F14,
		// Token: 0x0400051E RID: 1310
		F15,
		// Token: 0x0400051F RID: 1311
		F16,
		// Token: 0x04000520 RID: 1312
		F17,
		// Token: 0x04000521 RID: 1313
		F18,
		// Token: 0x04000522 RID: 1314
		F19,
		// Token: 0x04000523 RID: 1315
		F20,
		// Token: 0x04000524 RID: 1316
		F21,
		// Token: 0x04000525 RID: 1317
		F22,
		// Token: 0x04000526 RID: 1318
		F23,
		// Token: 0x04000527 RID: 1319
		F24,
		// Token: 0x04000528 RID: 1320
		NUMLOCK = 144,
		// Token: 0x04000529 RID: 1321
		SCROLL,
		// Token: 0x0400052A RID: 1322
		OEM_NEC_EQUAL,
		// Token: 0x0400052B RID: 1323
		OEM_FJ_JISHO = 146,
		// Token: 0x0400052C RID: 1324
		OEM_FJ_MASSHOU,
		// Token: 0x0400052D RID: 1325
		OEM_FJ_TOUROKU,
		// Token: 0x0400052E RID: 1326
		OEM_FJ_LOYA,
		// Token: 0x0400052F RID: 1327
		OEM_FJ_ROYA,
		// Token: 0x04000530 RID: 1328
		LSHIFT = 160,
		// Token: 0x04000531 RID: 1329
		RSHIFT,
		// Token: 0x04000532 RID: 1330
		LCONTROL,
		// Token: 0x04000533 RID: 1331
		RCONTROL,
		// Token: 0x04000534 RID: 1332
		LMENU,
		// Token: 0x04000535 RID: 1333
		RMENU,
		// Token: 0x04000536 RID: 1334
		BROWSER_BACK,
		// Token: 0x04000537 RID: 1335
		BROWSER_FORWARD,
		// Token: 0x04000538 RID: 1336
		BROWSER_REFRESH,
		// Token: 0x04000539 RID: 1337
		BROWSER_STOP,
		// Token: 0x0400053A RID: 1338
		BROWSER_SEARCH,
		// Token: 0x0400053B RID: 1339
		BROWSER_FAVORITES,
		// Token: 0x0400053C RID: 1340
		BROWSER_HOME,
		// Token: 0x0400053D RID: 1341
		VOLUME_MUTE,
		// Token: 0x0400053E RID: 1342
		VOLUME_DOWN,
		// Token: 0x0400053F RID: 1343
		VOLUME_UP,
		// Token: 0x04000540 RID: 1344
		MEDIA_NEXT_TRACK,
		// Token: 0x04000541 RID: 1345
		MEDIA_PREV_TRACK,
		// Token: 0x04000542 RID: 1346
		MEDIA_STOP,
		// Token: 0x04000543 RID: 1347
		MEDIA_PLAY_PAUSE,
		// Token: 0x04000544 RID: 1348
		LAUNCH_MAIL,
		// Token: 0x04000545 RID: 1349
		LAUNCH_MEDIA_SELECT,
		// Token: 0x04000546 RID: 1350
		LAUNCH_APP1,
		// Token: 0x04000547 RID: 1351
		LAUNCH_APP2,
		// Token: 0x04000548 RID: 1352
		OEM_1 = 186,
		// Token: 0x04000549 RID: 1353
		OEM_PLUS,
		// Token: 0x0400054A RID: 1354
		OEM_COMMA,
		// Token: 0x0400054B RID: 1355
		OEM_MINUS,
		// Token: 0x0400054C RID: 1356
		OEM_PERIOD,
		// Token: 0x0400054D RID: 1357
		OEM_2,
		// Token: 0x0400054E RID: 1358
		OEM_3,
		// Token: 0x0400054F RID: 1359
		OEM_4 = 219,
		// Token: 0x04000550 RID: 1360
		OEM_5,
		// Token: 0x04000551 RID: 1361
		OEM_6,
		// Token: 0x04000552 RID: 1362
		OEM_7,
		// Token: 0x04000553 RID: 1363
		OEM_8,
		// Token: 0x04000554 RID: 1364
		OEM_AX = 225,
		// Token: 0x04000555 RID: 1365
		OEM_102,
		// Token: 0x04000556 RID: 1366
		ICO_HELP,
		// Token: 0x04000557 RID: 1367
		ICO_00,
		// Token: 0x04000558 RID: 1368
		PROCESSKEY,
		// Token: 0x04000559 RID: 1369
		ICO_CLEAR,
		// Token: 0x0400055A RID: 1370
		PACKET,
		// Token: 0x0400055B RID: 1371
		OEM_RESET = 233,
		// Token: 0x0400055C RID: 1372
		OEM_JUMP,
		// Token: 0x0400055D RID: 1373
		OEM_PA1,
		// Token: 0x0400055E RID: 1374
		OEM_PA2,
		// Token: 0x0400055F RID: 1375
		OEM_PA3,
		// Token: 0x04000560 RID: 1376
		OEM_WSCTRL,
		// Token: 0x04000561 RID: 1377
		OEM_CUSEL,
		// Token: 0x04000562 RID: 1378
		OEM_ATTN,
		// Token: 0x04000563 RID: 1379
		OEM_FINISH,
		// Token: 0x04000564 RID: 1380
		OEM_COPY,
		// Token: 0x04000565 RID: 1381
		OEM_AUTO,
		// Token: 0x04000566 RID: 1382
		OEM_ENLW,
		// Token: 0x04000567 RID: 1383
		OEM_BACKTAB,
		// Token: 0x04000568 RID: 1384
		ATTN,
		// Token: 0x04000569 RID: 1385
		CRSEL,
		// Token: 0x0400056A RID: 1386
		EXSEL,
		// Token: 0x0400056B RID: 1387
		EREOF,
		// Token: 0x0400056C RID: 1388
		PLAY,
		// Token: 0x0400056D RID: 1389
		ZOOM,
		// Token: 0x0400056E RID: 1390
		NONAME,
		// Token: 0x0400056F RID: 1391
		PA1,
		// Token: 0x04000570 RID: 1392
		OEM_CLEAR,
		// Token: 0x04000571 RID: 1393
		Last
	}
}