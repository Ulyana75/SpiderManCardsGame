using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCards : MonoBehaviour {

    public Text a, c, d;
    public Image b;
    public Sprite[] textures = new Sprite[276];
    public GameObject obj;
    public Cards[] kard = new Cards[276];
    public int[] playercards = new int[240];
    public int[] computercards = new int[240];
    int i = 0, j = 0;
    bool[] coloda = new bool[276];
    public GameObject[] playerobj = new GameObject[120];
    public GameObject[] computerobj = new GameObject[120];
    bool t = true, t1 = true, t2 = true, t3 = false;
    float time;
    public int playerChoise = 5;
    public GameObject but1, but2, but3, but4, but5, but6;
    float k = StaticClass.k;

    private void Awake()
    {
        StaticClass.b = Random.Range(0, 2);
    }

    // Use this for initialization
    void Start () {
        c.gameObject.transform.position = new Vector3(8, 4);
        d.gameObject.transform.position = new Vector3(8, -4);

        ButtonsSetActive(false);
        b.gameObject.SetActive(false);
        GameObject.Find("ScriptForButtons").GetComponent<ButtonsScript>().b.gameObject.SetActive(false);

        for (int z = 1; z < 231; z++) coloda[z] = true;
        for (int z = 231; z < 266; z++) coloda[z] = false;
        for (int z = 266; z < 276; z++) coloda[z] = true;
        coloda[142] = false;

        for (int z = 1; z < 276; z++) kard[z] = new Cards();
        for (int z = 0; z < 120; z++) { playerobj[z] = new GameObject(); computerobj[z] = new GameObject(); }

        kard[1].i = 275; kard[1].sila = 286; kard[1].sl = 213; kard[1].ou = 140; kard[1].bn = 266; 
        kard[2].i = 130; kard[2].sila = 71; kard[2].sl = 112; kard[2].ou = 54; kard[2].bn = 68; 
        kard[3].i = 133; kard[3].sila = 104; kard[3].sl = 354; kard[3].ou = 349; kard[3].bn = 202; 
        kard[4].i = 112; kard[4].sila = 164; kard[4].sl = 186; kard[4].ou = 68; kard[4].bn = 139;
        kard[5].i = 259; kard[5].sila = 253; kard[5].sl = 159; kard[5].ou = 201; kard[5].bn = 211;
        kard[6].i = 208; kard[6].sila = 127; kard[6].sl = 131; kard[6].ou = 158; kard[6].bn = 349;
        kard[7].i = 201; kard[7].sila = 213; kard[7].sl = 141; kard[7].ou = 68; kard[7].bn = 499;
        kard[8].i = 424; kard[8].sila = 282; kard[8].sl = 350; kard[8].ou = 413; kard[8].bn = 271;
        kard[9].i = 74; kard[9].sila = 96; kard[9].sl = 136; kard[9].ou = 243; kard[9].bn = 142;
        kard[10].i = 123; kard[10].sila = 245; kard[10].sl = 143; kard[10].ou = 72; kard[10].bn = 202;
        kard[11].i = 126; kard[11].sila = 114; kard[11].sl = 203; kard[11].ou = 327; kard[11].bn = 146;
        kard[12].i = 140; kard[12].sila = 415; kard[12].sl = 135; kard[12].ou = 74; kard[12].bn = 180;
        kard[13].i = 135; kard[13].sila = 223; kard[13].sl = 207; kard[13].ou = 68; kard[13].bn = 141;
        kard[14].i = 276; kard[14].sila = 273; kard[14].sl = 132; kard[14].ou = 70; kard[14].bn = 199;
        kard[15].i = 139; kard[15].sila = 83; kard[15].sl = 137; kard[15].ou = 25; kard[15].bn = 32;
        kard[16].i = 129; kard[16].sila = 143; kard[16].sl = 136; kard[16].ou = 58; kard[16].bn = 286;
        kard[17].i = 279; kard[17].sila = 137; kard[17].sl = 498; kard[17].ou = 418; kard[17].bn = 201;
        kard[18].i = 274; kard[18].sila = 60; kard[18].sl = 71; kard[18].ou = 53; kard[18].bn = 68;
        kard[19].i = 73; kard[19].sila = 205; kard[19].sl = 213; kard[19].ou = 61; kard[19].bn = 137;
        kard[20].i = 136; kard[20].sila = 327; kard[20].sl = 135; kard[20].ou = 123; kard[20].bn = 86;
        kard[21].i = 216; kard[21].sila = 267; kard[21].sl = 206; kard[21].ou = 70; kard[21].bn = 253;
        kard[22].i = 137; kard[22].sila = 230; kard[22].sl = 199; kard[22].ou = 265; kard[22].bn = 276;
        kard[23].i = 75; kard[23].sila = 92; kard[23].sl = 83; kard[23].ou = 62; kard[23].bn = 138;
        kard[24].i = 142; kard[24].sila = 136; kard[24].sl = 127; kard[24].ou = 276; kard[24].bn = 119;
        kard[25].i = 303; kard[25].sila = 227; kard[25].sl = 185; kard[25].ou = 59; kard[25].bn = 137;
        kard[26].i = 97; kard[26].sila = 83; kard[26].sl = 106; kard[26].ou = 72; kard[26].bn = 142;
        kard[27].i = 357; kard[27].sila = 135; kard[27].sl = 128; kard[27].ou = 84; kard[27].bn = 141;
        kard[28].i = 327; kard[28].sila = 141; kard[28].sl = 127; kard[28].ou = 66; kard[28].bn = 285;
        kard[29].i = 124; kard[29].sila = 99; kard[29].sl = 136; kard[29].ou = 72; kard[29].bn = 84;
        kard[30].i = 142; kard[30].sila = 428; kard[30].sl = 139; kard[30].ou = 68; kard[30].bn = 346;
        kard[31].i = 389; kard[31].sila = 419; kard[31].sl = 345; kard[31].ou = 372; kard[31].bn = 200;
        kard[32].i = 339; kard[32].sila = 278; kard[32].sl = 98; kard[32].ou = 135; kard[32].bn = 83;
        kard[33].i = 140; kard[33].sila = 52; kard[33].sl = 89; kard[33].ou = 42; kard[33].bn = 31;
        kard[34].i = 286; kard[34].sila = 423; kard[34].sl = 296; kard[34].ou = 228; kard[34].bn = 276;
        kard[35].i = 153; kard[35].sila = 159; kard[35].sl = 202; kard[35].ou = 63; kard[35].bn = 277;
        kard[36].i = 219; kard[36].sila = 136; kard[36].sl = 85; kard[36].ou = 347; kard[36].bn = 93;
        kard[37].i = 261; kard[37].sila = 42; kard[37].sl = 132; kard[37].ou = 64; kard[37].bn = 139;
        kard[38].i = 345; kard[38].sila = 210; kard[38].sl = 138; kard[38].ou = 97; kard[38].bn = 415;
        kard[39].i = 197; kard[39].sila = 138; kard[39].sl = 128; kard[39].ou = 36; kard[39].bn = 142;
        kard[40].i = 305; kard[40].sila = 109; kard[40].sl = 253; kard[40].ou = 140; kard[40].bn = 213;
        kard[41].i = 83; kard[41].sila = 157; kard[41].sl = 133; kard[41].ou = 75; kard[41].bn = 349;
        kard[42].i = 136; kard[42].sila = 227; kard[42].sl = 136; kard[42].ou = 73; kard[42].bn = 279;
        kard[43].i = 203; kard[43].sila = 278; kard[43].sl = 214; kard[43].ou = 306; kard[43].bn = 210;
        kard[44].i = 85; kard[44].sila = 428; kard[44].sl = 367; kard[44].ou = 428; kard[44].bn = 275;
        kard[45].i = 274; kard[45].sila = 285; kard[45].sl = 198; kard[45].ou = 99; kard[45].bn = 289;
        kard[46].i = 344; kard[46].sila = 409; kard[46].sl = 373; kard[46].ou = 487; kard[46].bn = 382;
        kard[47].i = 139; kard[47].sila = 226; kard[47].sl = 143; kard[47].ou = 84; kard[47].bn = 150;
        kard[48].i = 281; kard[48].sila = 472; kard[48].sl = 373; kard[48].ou = 285; kard[48].bn = 489;
        kard[49].i = 140; kard[49].sila = 139; kard[49].sl = 87; kard[49].ou = 275; kard[49].bn = 168;
        kard[50].i = 85; kard[50].sila = 348; kard[50].sl = 133; kard[50].ou = 128; kard[50].bn = 210;
        kard[51].i = 136; kard[51].sila = 499; kard[51].sl = 101; kard[51].ou = 85; kard[51].bn = 212;
        kard[52].i = 70; kard[52].sila = 345; kard[52].sl = 154; kard[52].ou = 83; kard[52].bn = 52;
        kard[53].i = 347; kard[53].sila = 253; kard[53].sl = 245; kard[53].ou = 78; kard[53].bn = 125;
        kard[54].i = 198; kard[54].sila = 139; kard[54].sl = 497; kard[54].ou = 401; kard[54].bn = 145;
        kard[55].i = 187; kard[55].sila = 279; kard[55].sl = 133; kard[55].ou = 87; kard[55].bn = 348;
        kard[56].i = 198; kard[56].sila = 135; kard[56].sl = 129; kard[56].ou = 67; kard[56].bn = 426;
        kard[57].i = 207; kard[57].sila = 472; kard[57].sl = 373; kard[57].ou = 282; kard[57].bn = 489;
        kard[58].i = 153; kard[58].sila = 352; kard[58].sl = 497; kard[58].ou = 425; kard[58].bn = 206;
        kard[59].i = 198; kard[59].sila = 276; kard[59].sl = 210; kard[59].ou = 85; kard[59].bn = 275;
        kard[60].i = 137; kard[60].sila = 498; kard[60].sl = 479; kard[60].ou = 424; kard[60].bn = 279;
        kard[61].i = 211; kard[61].sila = 430; kard[61].sl = 236; kard[61].ou = 150; kard[61].bn = 213;
        kard[62].i = 138; kard[62].sila = 99; kard[62].sl = 139; kard[62].ou = 56; kard[62].bn = 121;
        kard[63].i = 279; kard[63].sila = 232; kard[63].sl = 248; kard[63].ou = 215; kard[63].bn = 144;
        kard[64].i = 43; kard[64].sila = 212; kard[64].sl = 117; kard[64].ou = 56; kard[64].bn = 92;
        kard[65].i = 257; kard[65].sila = 274; kard[65].sl = 142; kard[65].ou = 71; kard[65].bn = 135;
        kard[66].i = 210; kard[66].sila = 129; kard[66].sl = 134; kard[66].ou = 62; kard[66].bn = 110;
        kard[67].i = 142; kard[67].sila = 138; kard[67].sl = 126; kard[67].ou = 51; kard[67].bn = 275;
        kard[68].i = 198; kard[68].sila = 133; kard[68].sl = 87; kard[68].ou = 68; kard[68].bn = 53;
        kard[69].i = 133; kard[69].sila = 129; kard[69].sl = 213; kard[69].ou = 68; kard[69].bn = 276;
        kard[70].i = 139; kard[70].sila = 65; kard[70].sl = 142; kard[70].ou = 54; kard[70].bn = 63;
        kard[71].i = 198; kard[71].sila = 185; kard[71].sl = 214; kard[71].ou = 71; kard[71].bn = 63;
        kard[72].i = 138; kard[72].sila = 127; kard[72].sl = 275; kard[72].ou = 63; kard[72].bn = 198;
        kard[73].i = 194; kard[73].sila = 210; kard[73].sl = 129; kard[73].ou = 64; kard[73].bn = 348;
        kard[74].i = 140; kard[74].sila = 415; kard[74].sl = 136; kard[74].ou = 144; kard[74].bn = 199;
        kard[75].i = 498; kard[75].sila = 497; kard[75].sl = 499; kard[75].ou = 499; kard[75].bn = 496;
        kard[76].i = 397; kard[76].sila = 84; kard[76].sl = 187; kard[76].ou = 482; kard[76].bn = 138;
        kard[77].i = 387; kard[77].sila = 409; kard[77].sl = 353; kard[77].ou = 421; kard[77].bn = 211;
        kard[78].i = 487; kard[78].sila = 472; kard[78].sl = 499; kard[78].ou = 498; kard[78].bn = 492;
        kard[79].i = 126; kard[79].sila = 265; kard[79].sl = 499; kard[79].ou = 185; kard[79].bn = 129;
        kard[80].i = 211; kard[80].sila = 136; kard[80].sl = 125; kard[80].ou = 68; kard[80].bn = 107;
        kard[81].i = 197; kard[81].sila = 203; kard[81].sl = 182; kard[81].ou = 71; kard[81].bn = 211;
        kard[82].i = 238; kard[82].sila = 438; kard[82].sl = 472; kard[82].ou = 498; kard[82].bn = 457;
        kard[83].i = 65; kard[83].sila = 58; kard[83].sl = 49; kard[83].ou = 70; kard[83].bn = 67;
        kard[84].i = 278; kard[84].sila = 132; kard[84].sl = 213; kard[84].ou = 118; kard[84].bn = 129;
        kard[85].i = 128; kard[85].sila = 132; kard[85].sl = 118; kard[85].ou = 54; kard[85].bn = 175;
        kard[86].i = 342; kard[86].sila = 418; kard[86].sl = 349; kard[86].ou = 196; kard[86].bn = 413;
        kard[87].i = 186; kard[87].sila = 199; kard[87].sl = 136; kard[87].ou = 66; kard[87].bn = 133;
        kard[88].i = 139; kard[88].sila = 275; kard[88].sl = 267; kard[88].ou = 255; kard[88].bn = 137;
        kard[89].i = 87; kard[89].sila = 101; kard[89].sl = 112; kard[89].ou = 352; kard[89].bn = 135;
        kard[90].i = 138; kard[90].sila = 210; kard[90].sl = 126; kard[90].ou = 65; kard[90].bn = 347;
        kard[91].i = 215; kard[91].sila = 132; kard[91].sl = 126; kard[91].ou = 67; kard[91].bn = 186;
        kard[92].i = 274; kard[92].sila = 265; kard[92].sl = 187; kard[92].ou = 71; kard[92].bn = 253;
        kard[93].i = 214; kard[93].sila = 132; kard[93].sl = 128; kard[93].ou = 49; kard[93].bn = 425;
        kard[94].i = 422; kard[94].sila = 124; kard[94].sl = 410; kard[94].ou = 72; kard[94].bn = 271;
        kard[95].i = 139; kard[95].sila = 122; kard[95].sl = 117; kard[95].ou = 263; kard[95].bn = 118;
        kard[96].i = 153; kard[96].sila = 122; kard[96].sl = 101; kard[96].ou = 400; kard[96].bn = 98;
        kard[97].i = 63; kard[97].sila = 127; kard[97].sl = 109; kard[97].ou = 36; kard[97].bn = 59;
        kard[98].i = 174; kard[98].sila = 322; kard[98].sl = 126; kard[98].ou = 275; kard[98].bn = 117;
        kard[99].i = 200; kard[99].sila = 418; kard[99].sl = 264; kard[99].ou = 70; kard[99].bn = 266;
        kard[100].i = 186; kard[100].sila = 175; kard[100].sl = 122; kard[100].ou = 71; kard[100].bn = 497;
        kard[101].i = 67; kard[101].sila = 311; kard[101].sl = 125; kard[101].ou = 53; kard[101].bn = 137;
        kard[102].i = 487; kard[102].sila = 392; kard[102].sl = 337; kard[102].ou = 472; kard[102].bn = 299;
        kard[103].i = 136; kard[103].sila = 126; kard[103].sl = 110; kard[103].ou = 84; kard[103].bn = 133;
        kard[104].i = 125; kard[104].sila = 135; kard[104].sl = 132; kard[104].ou = 73; kard[104].bn = 124;
        kard[105].i = 263; kard[105].sila = 256; kard[105].sl = 202; kard[105].ou = 64; kard[105].bn = 348;
        kard[106].i = 127; kard[106].sila = 344; kard[106].sl = 125; kard[106].ou = 64; kard[106].bn = 96;
        kard[107].i = 198; kard[107].sila = 132; kard[107].sl = 140; kard[107].ou = 205; kard[107].bn = 199;
        kard[108].i = 200; kard[108].sila = 186; kard[108].sl = 264; kard[108].ou = 271; kard[108].bn = 258;
        kard[109].i = 266; kard[109].sila = 128; kard[109].sl = 118; kard[109].ou = 85; kard[109].bn = 101;
        kard[110].i = 127; kard[110].sila = 95; kard[110].sl = 102; kard[110].ou = 199; kard[110].bn = 114;
        kard[111].i = 194; kard[111].sila = 133; kard[111].sl = 126; kard[111].ou = 186; kard[111].bn = 121;
        kard[112].i = 48; kard[112].sila = 277; kard[112].sl = 63; kard[112].ou = 104; kard[112].bn = 67;
        kard[113].i = 186; kard[113].sila = 129; kard[113].sl = 102; kard[113].ou = 67; kard[113].bn = 125;
        kard[114].i = 126; kard[114].sila = 118; kard[114].sl = 415; kard[114].ou = 65; kard[114].bn = 393;
        kard[115].i = 139; kard[115].sila = 277; kard[115].sl = 184; kard[115].ou = 200; kard[115].bn = 172;
        kard[116].i = 256; kard[116].sila = 138; kard[116].sl = 111; kard[116].ou = 62; kard[116].bn = 499;
        kard[117].i = 126; kard[117].sila = 487; kard[117].sl = 498; kard[117].ou = 499; kard[117].bn = 499;
        kard[118].i = 107; kard[118].sila = 156; kard[118].sl = 287; kard[118].ou = 376; kard[118].bn = 97;
        kard[119].i = 187; kard[119].sila = 278; kard[119].sl = 262; kard[119].ou = 187; kard[119].bn = 400;
        kard[120].i = 139; kard[120].sila = 108; kard[120].sl = 206; kard[120].ou = 255; kard[120].bn = 125;
        kard[121].i = 342; kard[121].sila = 237; kard[121].sl = 125; kard[121].ou = 62; kard[121].bn = 92;
        kard[122].i = 263; kard[122].sila = 252; kard[122].sl = 304; kard[122].ou = 224; kard[122].bn = 263;
        kard[123].i = 275; kard[123].sila = 286; kard[123].sl = 213; kard[123].ou = 207; kard[123].bn = 345;
        kard[124].i = 124; kard[124].sila = 263; kard[124].sl = 58; kard[124].ou = 64; kard[124].bn = 128;
        kard[125].i = 186; kard[125].sila = 64; kard[125].sl = 124; kard[125].ou = 215; kard[125].bn = 194;
        kard[126].i = 275; kard[126].sila = 286; kard[126].sl = 213; kard[126].ou = 164; kard[126].bn = 396;
        kard[127].i = 342; kard[127].sila = 254; kard[127].sl = 195; kard[127].ou = 382; kard[127].bn = 135;
        kard[128].i = 196; kard[128].sila = 185; kard[128].sl = 174; kard[128].ou = 63; kard[128].bn = 132;
        kard[129].i = 482; kard[129].sila = 341; kard[129].sl = 464; kard[129].ou = 138; kard[129].bn = 476;
        kard[130].i = 275; kard[130].sila = 296; kard[130].sl = 213; kard[130].ou = 359; kard[130].bn = 432;
        kard[131].i = 183; kard[131].sila = 137; kard[131].sl = 104; kard[131].ou = 262; kard[131].bn = 97;
        kard[132].i = 265; kard[132].sila = 125; kard[132].sl = 473; kard[132].ou = 417; kard[132].bn = 135;
        kard[133].i = 275; kard[133].sila = 264; kard[133].sl = 213; kard[133].ou = 100; kard[133].bn = 237;
        kard[134].i = 70; kard[134].sila = 274; kard[134].sl = 165; kard[134].ou = 65; kard[134].bn = 399;
        kard[135].i = 184; kard[135].sila = 279; kard[135].sl = 474; kard[135].ou = 341; kard[135].bn = 259;
        kard[136].i = 65; kard[136].sila = 56; kard[136].sl = 70; kard[136].ou = 43; kard[136].bn = 58;
        kard[137].i = 290; kard[137].sila = 320; kard[137].sl = 298; kard[137].ou = 360; kard[137].bn = 344;
        kard[138].i = 386; kard[138].sila = 65; kard[138].sl = 197; kard[138].ou = 64; kard[138].bn = 66;
        kard[139].i = 332; kard[139].sila = 410; kard[139].sl = 199; kard[139].ou = 187; kard[139].bn = 275;
        kard[140].i = 255; kard[140].sila = 290; kard[140].sl = 210; kard[140].ou = 115; kard[140].bn = 275;
        kard[141].i = 497; kard[141].sila = 499; kard[141].sl = 378; kard[141].ou = 475; kard[141].bn = 334;
        //kard[142].i = 255; kard[142].sila = 290; kard[142].sl = 210; kard[142].ou = 115; kard[142].bn = 275; - splav
        kard[143].i = 132; kard[143].sila = 125; kard[143].sl = 140; kard[143].ou = 351; kard[143].bn = 110;
        kard[144].i = 257; kard[144].sila = 275; kard[144].sl = 213; kard[144].ou = 140; kard[144].bn = 268;
        kard[145].i = 122; kard[145].sila = 346; kard[145].sl = 341; kard[145].ou = 266; kard[145].bn = 418;
        kard[146].i = 200; kard[146].sila = 273; kard[146].sl = 78; kard[146].ou = 71; kard[146].bn = 264;
        kard[147].i = 260; kard[147].sila = 209; kard[147].sl = 104; kard[147].ou = 140; kard[147].bn = 250;
        kard[148].i = 489; kard[148].sila = 473; kard[148].sl = 498; kard[148].ou = 455; kard[148].bn = 135;
        kard[149].i = 333; kard[149].sila = 183; kard[149].sl = 164; kard[149].ou = 348; kard[149].bn = 154;
        kard[150].i = 167; kard[150].sila = 179; kard[150].sl = 260; kard[150].ou = 171; kard[150].bn = 336;
        kard[151].i = 275; kard[151].sila = 401; kard[151].sl = 301; kard[151].ou = 199; kard[151].bn = 329;
        kard[152].i = 264; kard[152].sila = 301; kard[152].sl = 254; kard[152].ou = 176; kard[152].bn = 329;
        kard[153].i = 255; kard[153].sila = 224; kard[153].sl = 329; kard[153].ou = 400; kard[153].bn = 228;
        kard[154].i = 290; kard[154].sila = 295; kard[154].sl = 220; kard[154].ou = 145; kard[154].bn = 316;
        kard[155].i = 265; kard[155].sila = 63; kard[155].sl = 182; kard[155].ou = 60; kard[155].bn = 138;
        kard[156].i = 275; kard[156].sila = 327; kard[156].sl = 213; kard[156].ou = 140; kard[156].bn = 268;
        kard[157].i = 129; kard[157].sila = 110; kard[157].sl = 137; kard[157].ou = 68; kard[157].bn = 264;
        kard[158].i = 344; kard[158].sila = 99; kard[158].sl = 499; kard[158].ou = 71; kard[158].bn = 137;
        kard[159].i = 264; kard[159].sila = 185; kard[159].sl = 139; kard[159].ou = 66; kard[159].bn = 401;
        kard[160].i = 65; kard[160].sila = 58; kard[160].sl = 71; kard[160].ou = 63; kard[160].bn = 40;
        kard[161].i = 187; kard[161].sila = 153; kard[161].sl = 264; kard[161].ou = 117; kard[161].bn = 269;
        kard[162].i = 275; kard[162].sila = 286; kard[162].sl = 213; kard[162].ou = 352; kard[162].bn = 268;
        kard[163].i = 275; kard[163].sila = 498; kard[163].sl = 479; kard[163].ou = 424; kard[163].bn = 279;
        kard[164].i = 55; kard[164].sila = 68; kard[164].sl = 42; kard[164].ou = 32; kard[164].bn = 49;
        kard[165].i = 200; kard[165].sila = 408; kard[165].sl = 326; kard[165].ou = 370; kard[165].bn = 401;
        kard[166].i = 177; kard[166].sila = 124; kard[166].sl = 101; kard[166].ou = 65; kard[166].bn = 183;
        kard[167].i = 153; kard[167].sila = 269; kard[167].sl = 115; kard[167].ou = 57; kard[167].bn = 251;
        kard[168].i = 197; kard[168].sila = 136; kard[168].sl = 129; kard[168].ou = 52; kard[168].bn = 119;
        kard[169].i = 275; kard[169].sila = 327; kard[169].sl = 213; kard[169].ou = 140; kard[169].bn = 268;
        kard[170].i = 201; kard[170].sila = 286; kard[170].sl = 213; kard[170].ou = 140; kard[170].bn = 494;
        kard[171].i = 111; kard[171].sila = 98; kard[171].sl = 109; kard[171].ou = 64; kard[171].bn = 263;
        kard[172].i = 300; kard[172].sila = 395; kard[172].sl = 299; kard[172].ou = 346; kard[172].bn = 411;
        kard[173].i = 263; kard[173].sila = 349; kard[173].sl = 141; kard[173].ou = 417; kard[173].bn = 70;
        kard[174].i = 488; kard[174].sila = 472; kard[174].sl = 167; kard[174].ou = 63; kard[174].bn = 266;
        kard[175].i = 275; kard[175].sila = 472; kard[175].sl = 373; kard[175].ou = 265; kard[175].bn = 494;
        kard[176].i = 66; kard[176].sila = 264; kard[176].sl = 200; kard[176].ou = 169; kard[176].bn = 197;
        kard[177].i = 275; kard[177].sila = 286; kard[177].sl = 213; kard[177].ou = 201; kard[177].bn = 258;
        kard[178].i = 268; kard[178].sila = 122; kard[178].sl = 183; kard[178].ou = 401; kard[178].bn = 185;
        kard[179].i = 411; kard[179].sila = 462; kard[179].sl = 459; kard[179].ou = 488; kard[179].bn = 275;
        kard[180].i = 65; kard[180].sila = 263; kard[180].sl = 259; kard[180].ou = 177; kard[180].bn = 64;
        kard[181].i = 175; kard[181].sila = 122; kard[181].sl = 152; kard[181].ou = 339; kard[181].bn = 157;
        kard[182].i = 66; kard[182].sila = 51; kard[182].sl = 48; kard[182].ou = 33; kard[182].bn = 61;
        kard[183].i = 329; kard[183].sila = 286; kard[183].sl = 213; kard[183].ou = 140; kard[183].bn = 279;
        kard[184].i = 275; kard[184].sila = 415; kard[184].sl = 213; kard[184].ou = 140; kard[184].bn = 279;
        kard[185].i = 298; kard[185].sila = 262; kard[185].sl = 332; kard[185].ou = 137; kard[185].bn = 449;
        kard[186].i = 374; kard[186].sila = 300; kard[186].sl = 312; kard[186].ou = 397; kard[186].bn = 197;
        kard[187].i = 264; kard[187].sila = 129; kard[187].sl = 116; kard[187].ou = 70; kard[187].bn = 139;
        kard[188].i = 261; kard[188].sila = 189; kard[188].sl = 177; kard[188].ou = 65; kard[188].bn = 342;
        kard[189].i = 55; kard[189].sila = 468; kard[189].sl = 253; kard[189].ou = 255; kard[189].bn = 218;
        kard[190].i = 265; kard[190].sila = 276; kard[190].sl = 203; kard[190].ou = 130; kard[190].bn = 248;
        kard[191].i = 488; kard[191].sila = 472; kard[191].sl = 213; kard[191].ou = 140; kard[191].bn = 268;
        kard[192].i = 137; kard[192].sila = 189; kard[192].sl = 174; kard[192].ou = 65; kard[192].bn = 349;
        kard[193].i = 66; kard[193].sila = 139; kard[193].sl = 122; kard[193].ou = 21; kard[193].bn = 54;
        kard[194].i = 248; kard[194].sila = 101; kard[194].sl = 162; kard[194].ou = 324; kard[194].bn = 128;
        kard[195].i = 67; kard[195].sila = 275; kard[195].sl = 187; kard[195].ou = 70; kard[195].bn = 254;
        kard[196].i = 132; kard[196].sila = 126; kard[196].sl = 117; kard[196].ou = 68; kard[196].bn = 70;
        kard[197].i = 122; kard[197].sila = 159; kard[197].sl = 97; kard[197].ou = 201; kard[197].bn = 136;
        kard[198].i = 126; kard[198].sila = 104; kard[198].sl = 120; kard[198].ou = 154; kard[198].bn = 119;
        kard[199].i = 275; kard[199].sila = 286; kard[199].sl = 213; kard[199].ou = 176; kard[199].bn = 268;
        kard[200].i = 479; kard[200].sila = 346; kard[200].sl = 275; kard[200].ou = 255; kard[200].bn = 263;
        kard[201].i = 197; kard[201].sila = 267; kard[201].sl = 200; kard[201].ou = 186; kard[201].bn = 124;
        kard[202].i = 345; kard[202].sila = 306; kard[202].sl = 139; kard[202].ou = 67; kard[202].bn = 186;
        kard[203].i = 275; kard[203].sila = 286; kard[203].sl = 213; kard[203].ou = 140; kard[203].bn = 268;
        kard[204].i = 185; kard[204].sila = 139; kard[204].sl = 177; kard[204].ou = 65; kard[204].bn = 168;
        kard[205].i = 137; kard[205].sila = 264; kard[205].sl = 197; kard[205].ou = 279; kard[205].bn = 254;
        kard[206].i = 119; kard[206].sila = 258; kard[206].sl = 188; kard[206].ou = 162; kard[206].bn = 200;
        kard[207].i = 265; kard[207].sila = 250; kard[207].sl = 183; kard[207].ou = 124; kard[207].bn = 305;
        kard[208].i = 196; kard[208].sila = 264; kard[208].sl = 346; kard[208].ou = 404; kard[208].bn = 253;
        kard[209].i = 128; kard[209].sila = 274; kard[209].sl = 173; kard[209].ou = 194; kard[209].bn = 246;
        kard[210].i = 129; kard[210].sila = 67; kard[210].sl = 88; kard[210].ou = 64; kard[210].bn = 70;
        kard[211].i = 321; kard[211].sila = 233; kard[211].sl = 107; kard[211].ou = 199; kard[211].bn = 101;
        kard[212].i = 152; kard[212].sila = 275; kard[212].sl = 198; kard[212].ou = 173; kard[212].bn = 122;
        kard[213].i = 135; kard[213].sila = 341; kard[213].sl = 125; kard[213].ou = 158; kard[213].bn = 98;
        kard[214].i = 332; kard[214].sila = 403; kard[214].sl = 264; kard[214].ou = 483; kard[214].bn = 309;
        kard[215].i = 200; kard[215].sila = 212; kard[215].sl = 187; kard[215].ou = 105; kard[215].bn = 155;
        kard[216].i = 264; kard[216].sila = 229; kard[216].sl = 195; kard[216].ou = 63; kard[216].bn = 243;
        kard[217].i = 124; kard[217].sila = 157; kard[217].sl = 128; kard[217].ou = 58; kard[217].bn = 117;
        kard[218].i = 125; kard[218].sila = 118; kard[218].sl = 138; kard[218].ou = 65; kard[218].bn = 44;
        kard[219].i = 77; kard[219].sila = 155; kard[219].sl = 98; kard[219].ou = 32; kard[219].bn = 141;
        kard[220].i = 266; kard[220].sila = 135; kard[220].sl = 115; kard[220].ou = 196; kard[220].bn = 184;
        kard[221].i = 328; kard[221].sila = 207; kard[221].sl = 136; kard[221].ou = 266; kard[221].bn = 251;
        kard[222].i = 290; kard[222].sila = 198; kard[222].sl = 300; kard[222].ou = 136; kard[222].bn = 323;
        kard[223].i = 285; kard[223].sila = 291; kard[223].sl = 226; kard[223].ou = 179; kard[223].bn = 272;
        kard[224].i = 119; kard[224].sila = 154; kard[224].sl = 182; kard[224].ou = 68; kard[224].bn = 199;
        kard[225].i = 120; kard[225].sila = 214; kard[225].sl = 129; kard[225].ou = 67; kard[225].bn = 277;
        kard[226].i = 96; kard[226].sila = 65; kard[226].sl = 147; kard[226].ou = 36; kard[226].bn = 15;
        kard[227].i = 275; kard[227].sila = 286; kard[227].sl = 213; kard[227].ou = 140; kard[227].bn = 268;
        kard[228].i = 199; kard[228].sila = 139; kard[228].sl = 133; kard[228].ou = 64; kard[228].bn = 125;
        kard[229].i = 274; kard[229].sila = 113; kard[229].sl = 136; kard[229].ou = 277; kard[229].bn = 187;
        kard[230].i = 65; kard[230].sila = 86; kard[230].sl = 75; kard[230].ou = 56; kard[230].bn = 63;
        kard[266].i = 325; kard[266].sila = 325; kard[266].sl = 430; kard[266].ou = 273; kard[266].bn = 390;
        kard[267].i = 245; kard[267].sila = 266; kard[267].sl = 203; kard[267].ou = 130; kard[267].bn = 258;
        kard[268].i = 275; kard[268].sila = 286; kard[268].sl = 213; kard[268].ou = 243; kard[268].bn = 268;
        kard[269].i = 267; kard[269].sila = 256; kard[269].sl = 201; kard[269].ou = 135; kard[269].bn = 264;
        kard[270].i = 122; kard[270].sila = 430; kard[270].sl = 175; kard[270].ou = 120; kard[270].bn = 460;
        kard[271].i = 302; kard[271].sila = 437; kard[271].sl = 210; kard[271].ou = 229; kard[271].bn = 298;
        kard[272].i = 275; kard[272].sila = 286; kard[272].sl = 259; kard[272].ou = 177; kard[272].bn = 268;
        kard[273].i = 280; kard[273].sila = 292; kard[273].sl = 244; kard[273].ou = 99; kard[273].bn = 275;
        kard[274].i = 155; kard[274].sila = 276; kard[274].sl = 205; kard[274].ou = 135; kard[274].bn = 247;
        kard[275].i = 280; kard[275].sila = 276; kard[275].sl = 210; kard[275].ou = 137; kard[275].bn = 499;


        while (i < k) 
        {
            int s = Random.Range(1, 276);
            while (coloda[s] == false)
                {
                    s++; if (s == 276) s = 1;
                }
            playercards[i] = s; i++; coloda[s] = false;
            s = Random.Range(1, 276);
            while (coloda[s] == false)
            {
                s++; if (s == 276) s = 1;
            }
            computercards[j] = s; j++; coloda[s] = false;
        }
        for (int z = 0; z < i; z++) 
        {
            playerobj[z] = obj;
            Instantiate(playerobj[z]);
            playerobj[z].tag = "player";
            playerobj[z].name = playercards[z].ToString();
            playerobj[z].transform.position = new Vector3(0, -3);
            playerobj[z].GetComponent<SpriteRenderer>().sortingOrder = i - z;
            playerobj[z].GetComponent<SpriteRenderer>().sprite = textures[playercards[z]];
        }
        for (int z = 0; z < j - 1; z++) 
        {
            computerobj[z] = obj;
            Instantiate(computerobj[z]);
            computerobj[z].tag = "computer";
            computerobj[z].name = computercards[z].ToString();
            computerobj[z].transform.position = new Vector3(0, 3);
            computerobj[z].GetComponent<SpriteRenderer>().sortingOrder = j - 1 - z;
            computerobj[z].GetComponent<SpriteRenderer>().sprite = textures[0];
        }
        computerobj[j - 1] = obj;
        Instantiate(computerobj[j - 1]);
        computerobj[j - 1].tag = "computer";
        computerobj[j - 1].name = computercards[j - 1].ToString() + "(Clone)";
        computerobj[j - 1].transform.position = new Vector3(0, 3);
        computerobj[j - 1].GetComponent<SpriteRenderer>().sortingOrder = 0;
        computerobj[j - 1].GetComponent<SpriteRenderer>().sprite = textures[0];

        StaticClass.kp = i; StaticClass.kc = j;
        StaticClass.mp = i; StaticClass.mc = j;
        StaticClass.layerp = 1; StaticClass.layerc = 0;
        StaticClass.ip = 0; StaticClass.ic = 0;

        /*Debug.Log("playercards:");
        for(int z=0; z<i; z++) Debug.Log(playercards[z]);
        Debug.Log("computercards:");
        for(int z=0; z<j; z++) Debug.Log(computercards[z]);*/
    }
	
	// Update is called once per frame
	void Update () {
        if(t) ComputerHod();
        if(t) PlayerHod();
        if(t2) PlayerMove();
        if(t1) WhoWin();
        if (t3) Timer();
        c.text = "Кол-во карт: " + StaticClass.kc.ToString();
        d.text = "Кол-во карт: " + StaticClass.kp.ToString();
    }


    void ComputerHod()
    {
        if (StaticClass.b == 0)
        {
            int num = computercards[StaticClass.ic];
            GameObject.Find("Main Camera").GetComponent<MoveCard>().card = GameObject.Find(num.ToString() + "(Clone)");
            GameObject.Find("Main Camera").GetComponent<MoveCard>().progress = 0;
            GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition = new Vector2(0, 3);
            GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition = new Vector2(-4, 0);
            GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;
            GameObject.Find(num.ToString() + "(Clone)").GetComponent<SpriteRenderer>().sprite = textures[num];
            b.gameObject.SetActive(true);
            b.gameObject.transform.position = new Vector3(-7, 3);
            int n = Max(computercards[StaticClass.ic]);
            if (n == 0) a.text = "Интеллект!";           
            if (n == 1) a.text = "Сила!";            
            if (n == 2) a.text = "Скорость и ловкость!";            
            if (n == 3) a.text = "Особые умения!";            
            if (n == 4) a.text = "Бойцовские навыки!";
            t = false;
        }
    }


    int Max(int number)
    {
        int a, b, c, d, e;
        int f = 5;
        a = kard[number].i; b = kard[number].sila; c = kard[number].sl; d = kard[number].ou; e = kard[number].bn;
        if ((a >= b) && (a >= c) && (a >= d) && (a >= e)) f = 0;
        if ((b >= a) && (b >= c) && (b >= d) && (b >= e)) f = 1;
        if ((c >= b) && (c >= a) && (c >= d) && (c >= e)) f = 2;
        if ((d >= b) && (d >= c) && (d >= a) && (d >= e)) f = 3;
        if ((e >= b) && (e >= c) && (e >= d) && (e >= a)) f = 4;
        return f;
    }


    void PlayerMove()
    {
        int r = computercards[StaticClass.ic];
        if ((StaticClass.b == 0) && (GameObject.Find(r.ToString() + "(Clone)").transform.position.x == -4)) 
        {
            if (Input.GetMouseButtonUp(0))
            {
                Vector2 click = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(click, Vector2.zero);
                if (hit.collider)
                {
                    if (hit.collider.tag == "player")
                    {
                        StaticClass.t1 = false;
                        int n = playercards[StaticClass.ip];
                        GameObject.Find(n.ToString() + "(Clone)").tag = "middle";
                        GameObject.Find("фон").transform.parent = null;
                        GameObject.Find("Main Camera").GetComponent<MoveCard>().card = GameObject.Find(n.ToString() + "(Clone)");
                        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress = 0;
                        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition = new Vector2(0, -3);
                        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition = new Vector2(4, 0);
                        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;
                        GameObject.Find(n.ToString() + "(Clone)").transform.localScale = new Vector3(1, 1);
                        t2 = false;
                    }
                }
            }
        }
    }


    void PlayerLose()
    {
        playercards[StaticClass.mp] = computercards[StaticClass.ic]; StaticClass.mp++;
        if (StaticClass.mp == k * 2) StaticClass.mp = 0;
        playercards[StaticClass.mp] = playercards[StaticClass.ip]; StaticClass.mp++;
        if (StaticClass.mp == k * 2) StaticClass.mp = 0;
        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sortingOrder = StaticClass.layerp - 1;
        StaticClass.layerp -= 1;
        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sortingOrder = StaticClass.layerp - 1;
        StaticClass.layerp -= 1;

        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").tag = "player";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card = GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition = new Vector2(-4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition = new Vector2(0, -3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress = 0;


        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").tag = "player";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card1 = GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition1 = new Vector2(4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition1 = new Vector2(0, -3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress1 = 0;
        

        b.gameObject.SetActive(false);
        ButtonsSetActive(false);
        GameObject.Find("ScriptForButtons").GetComponent<ButtonsScript>().b.gameObject.SetActive(false);
        StaticClass.b = 0;

        time = Time.time + 1;
        t3 = true;
        StaticClass.kp += 1; StaticClass.kc -= 1;
    }


    void PlayerWin()
    {
        computercards[StaticClass.mc] = playercards[StaticClass.ip]; StaticClass.mc++;
        if (StaticClass.mc == k * 2) StaticClass.mc = 0;
        computercards[StaticClass.mc] = computercards[StaticClass.ic]; StaticClass.mc++;
        if (StaticClass.mc == k * 2) StaticClass.mc = 0;
        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sortingOrder = StaticClass.layerc - 1;
        StaticClass.layerc -= 1;
        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sortingOrder = StaticClass.layerc - 1;
        StaticClass.layerc -= 1;

        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sprite = textures[0];
        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sprite = textures[0];

        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").tag = "computer";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card = GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition = new Vector2(-4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition = new Vector2(0, 3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress = 0;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;

        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").tag = "computer";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card1 = GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition1 = new Vector2(4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition1 = new Vector2(0, 3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress1 = 0;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;

        b.gameObject.SetActive(false);
        ButtonsSetActive(false);
        GameObject.Find("ScriptForButtons").GetComponent<ButtonsScript>().b.gameObject.SetActive(false);

        StaticClass.b = 1;
        time = Time.time + 1;
        t3 = true;
        StaticClass.kp -= 1; StaticClass.kc += 1;
    }


    void Nichya()
    {
        computercards[StaticClass.mc] = computercards[StaticClass.ic];
        StaticClass.mc++; if (StaticClass.mc == k * 2) StaticClass.mc = 0;
        playercards[StaticClass.mp] = playercards[StaticClass.ip];
        StaticClass.mp++; if (StaticClass.mp == k * 2) StaticClass.mp = 0;

        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sortingOrder = StaticClass.layerp - 1;
        StaticClass.layerp -= 1;
        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sortingOrder = StaticClass.layerc - 1;
        StaticClass.layerc -= 1;

        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").GetComponent<SpriteRenderer>().sprite = textures[0];

        GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").tag = "player";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card = GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition = new Vector2(-4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition = new Vector2(0, 3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress = 0;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;

        GameObject.Find(computercards[StaticClass.ic].ToString() + "(Clone)").tag = "computer";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card1 = GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition1 = new Vector2(4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition1 = new Vector2(0, -3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress1 = 0;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.05f;

        b.gameObject.SetActive(false);
        ButtonsSetActive(false);
        GameObject.Find("ScriptForButtons").GetComponent<ButtonsScript>().b.gameObject.SetActive(false);

        time = Time.time + 1;
        t3 = true;
    }


    public void WhoWin()
    {
        if (GameObject.Find(playercards[StaticClass.ip].ToString() + "(Clone)").transform.position.x == 4) 
        {
            int n = 5;
            if (StaticClass.b == 0) { n = Max(computercards[StaticClass.ic]); }
            else n = playerChoise;
            int nc = computercards[StaticClass.ic], np = playercards[StaticClass.ip];
            if (n == 0)
            {
                int res = GameObject.Find("Main Camera").GetComponent<Cards>().WhoMore(kard[nc].i, kard[np].i);
                if (res == 1) PlayerLose();
                if (res == 2) PlayerWin();
                if (res == 3) Nichya();
            }
            if (n == 1)
            {
                int res = GameObject.Find("Main Camera").GetComponent<Cards>().WhoMore(kard[nc].sila, kard[np].sila);
                if (res == 1) PlayerLose();
                if (res == 2) PlayerWin();
                if (res == 3) Nichya();
            }
            if (n == 2)
            {
                int res = GameObject.Find("Main Camera").GetComponent<Cards>().WhoMore(kard[nc].sl, kard[np].sl);
                if (res == 1) PlayerLose();
                if (res == 2) PlayerWin();
                if (res == 3) Nichya();
            }
            if (n == 3)
            {
                int res = GameObject.Find("Main Camera").GetComponent<Cards>().WhoMore(kard[nc].ou, kard[np].ou);
                if (res == 1) PlayerLose();
                if (res == 2) PlayerWin();
                if (res == 3) Nichya();
            }
            if (n == 4)
            {
                int res = GameObject.Find("Main Camera").GetComponent<Cards>().WhoMore(kard[nc].bn, kard[np].bn);
                if (res == 1) PlayerLose();
                if (res == 2) PlayerWin();
                if (res == 3) Nichya();
            }
            t1 = false;
        }
    }


    void Timer()
    {
        if (Time.time >= time)
        {
            t = true;
            StaticClass.ip++; StaticClass.ic++;
            if (StaticClass.ip == k * 2) StaticClass.ip = 0;
            if (StaticClass.ic == k * 2) StaticClass.ic = 0;
            t1 = true;
            t2 = true;
            t3 = false;
            StaticClass.t1 = true;
            EndGame();
        }
    }


    void PlayerHod()
    {
        if (StaticClass.b == 1)
        {
            ButtonsSetActive(true);
            t = false;
        }
    }


    public void ButtonsSetActive(bool b)
    {
        but1.SetActive(b); but2.SetActive(b); but3.SetActive(b);
        but4.SetActive(b); but5.SetActive(b); but6.SetActive(b);
        but1.transform.position = new Vector3(-5, -1.7f);
        but2.transform.position = new Vector3(-5, -2.4f);
        but3.transform.position = new Vector3(-5, -3.1f);
        but4.transform.position = new Vector3(-5, -3.8f);
        but5.transform.position = new Vector3(-5, -4.5f);
        but6.transform.position = new Vector3(-5, -1);
    }

    void EndGame()
    {
        if (StaticClass.kp == 0) Application.LoadLevel(2);
        DontDestroyOnLoad(GameObject.Find("Audio Source"));
        if (StaticClass.kc == 0) Application.LoadLevel(3);
        DontDestroyOnLoad(GameObject.Find("Audio Source"));
    }
}
