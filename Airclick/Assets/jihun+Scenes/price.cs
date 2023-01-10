using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class price : MonoBehaviour
{
// 게임오브젝트
    // 상단 메뉴
    public GameObject Coffee, Tea, Ade, Desert;
    // 중간 메뉴
    // 커피
    public GameObject Americano, CafeLatte, HazelnutLatte, VanillaLatte, CinnamonLatte, DryCappuccino;
    public GameObject DolceLatte, CaramelMaccihato, Einspanner, ChocoCafemoch, DalgonaLatte, Cocospanner;
    // 티
    public GameObject EarlGrey, Chamomile, Peppermint, GingerLemonTea, PeachIceTea, FreshLemonTea;
    public GameObject GrapefruitTea, FruitsIceTea, PeachBlossom, PlumTea, VinChaud, MilkTea;
    // 에이드
    public GameObject LemonAde, GrapefruitAde, LimeAde, GreenGrapeAde, StrawberryAde, PeachAde;
    // 디저트
    public GameObject ChocolateChipCookie, DoubleChocoChipCookie, MacadamiaCookie, PeanutButterCookie, BagelChipHoneyButter, BagelChipGarlicButter;
    public GameObject StrawberryMacaron, SaltedCaramelMacaron, YellowCheeseMacaron, ChocolateMacaron, InjeolmiMacaron, OreoMacaron;
    // 추가하기 버튼
    public GameObject Chuga;

// 버튼
    // 상단 메뉴
    public Button Btn_Coffee, Btn_Tea, Btn_Ade, Btn_Desert;
    // 중간 메뉴
    // 커피
    public Button Btn_Americano, Btn_CafeLatte, Btn_HazelnutLatte, Btn_VanillaLatte, Btn_CinnamonLatte, Btn_DryCappuccino;
    public Button Btn_DolceLatte, Btn_CaramelMaccihato, Btn_Einspanner, Btn_ChocoCafemoch, Btn_DalgonaLatte, Btn_Cocospanner;
    // 티
    public Button Btn_EarlGrey, Btn_Chamomile, Btn_Peppermint, Btn_GingerLemonTea, Btn_PeachIceTea, Btn_FreshLemonTea;
    public Button Btn_GrapefruitTea, Btn_FruitsIceTea, Btn_PeachBlossom, Btn_PlumTea, Btn_VinChaud, Btn_MilkTea;
    // 에이드
    public Button Btn_LemonAde, Btn_GrapefruitAde, Btn_LimeAde, Btn_GreenGrapeAde, Btn_StrawberryAde, Btn_PeachAde;
    // 디저트
    public Button Btn_ChocolateChipCookie, Btn_DoubleChocoChipCookie, Btn_MacadamiaCookie, Btn_PeanutButterCookie, Btn_BagelChipHoneyButter, Btn_BagelChipGarlicButter;
    public Button Btn_StrawberryMacaron, Btn_SaltedCaramelMacaron, Btn_YellowCheeseMacaron, Btn_ChocolateMacaron, Btn_InjeolmiMacaron, Btn_OreoMacaron;
    // 추가하기 버튼
    public Button Btn_Chuga;

    public int[,] array = new int[12, 12];
    public int a ;
    public int b ;
    public int sangsock;

    public Text txtprice;

    // Start is called before the first frame update
    void Start()
    {
// 상단메뉴
        Coffee = GameObject.Find("CButton");
        Btn_Coffee = Coffee.transform.GetComponent<Button>();
        Btn_Coffee.onClick.AddListener(Ck_Coffee);

        Tea = GameObject.Find("TButton");
        Btn_Tea = Tea.transform.GetComponent<Button>();
        Btn_Tea.onClick.AddListener(Ck_Tea);

        Ade = GameObject.Find("AButton");
        Btn_Ade = Ade.transform.GetComponent<Button>();
        Btn_Ade.onClick.AddListener(Ck_Ade);

        Desert = GameObject.Find("DButton");
        Btn_Desert = Desert.transform.GetComponent<Button>();
        Btn_Desert.onClick.AddListener(Ck_Desert);
// 중간메뉴
    // 커피
        Americano = GameObject.Find("아메리카노");
        Btn_Americano = Americano.transform.GetComponent<Button>();
        Btn_Americano.onClick.AddListener(Ck_Americano);

        CafeLatte = GameObject.Find("카페라떼");
        Btn_CafeLatte = CafeLatte.transform.GetComponent<Button>();
        Btn_CafeLatte.onClick.AddListener(Ck_CafeLatte);

        HazelnutLatte = GameObject.Find("헤이즐넛 라떼");
        Btn_HazelnutLatte = HazelnutLatte.transform.GetComponent<Button>();
        Btn_HazelnutLatte.onClick.AddListener(Ck_HazelnutLatte);

        VanillaLatte = GameObject.Find("바닐라 라떼");
        Btn_VanillaLatte = VanillaLatte.transform.GetComponent<Button>();
        Btn_VanillaLatte.onClick.AddListener(Ck_VanillaLatte);

        CinnamonLatte = GameObject.Find("시나몬 라떼");
        Btn_CinnamonLatte = CinnamonLatte.transform.GetComponent<Button>();
        Btn_CinnamonLatte.onClick.AddListener(Ck_CinnamonLatte);

        DryCappuccino = GameObject.Find("드라이 카푸치노");
        Btn_DryCappuccino = DryCappuccino.transform.GetComponent<Button>();
        Btn_DryCappuccino.onClick.AddListener(Ck_DryCappuccino);

        DolceLatte = GameObject.Find("돌체라떼");
        Btn_DolceLatte = DolceLatte.transform.GetComponent<Button>();
        Btn_DolceLatte.onClick.AddListener(Ck_DolceLatte);

        CaramelMaccihato = GameObject.Find("카라멜마끼야또");
        Btn_CaramelMaccihato = CaramelMaccihato.transform.GetComponent<Button>();
        Btn_CaramelMaccihato.onClick.AddListener(Ck_CaramelMaccihato);

        Einspanner = GameObject.Find("아인슈페너");
        Btn_Einspanner = Einspanner.transform.GetComponent<Button>();
        Btn_Einspanner.onClick.AddListener(Ck_Einspanner);

        ChocoCafemoch = GameObject.Find("초코카페모카");
        Btn_ChocoCafemoch = ChocoCafemoch.transform.GetComponent<Button>();
        Btn_ChocoCafemoch.onClick.AddListener(Ck_ChocoCafemoch);

        DalgonaLatte = GameObject.Find("달고나라떼");
        Btn_DalgonaLatte = DalgonaLatte.transform.GetComponent<Button>();
        Btn_DalgonaLatte.onClick.AddListener(Ck_DalgonaLatte);

        Cocospanner = GameObject.Find("코코슈페너");
        Btn_Cocospanner = Cocospanner.transform.GetComponent<Button>();
        Btn_Cocospanner.onClick.AddListener(Ck_Cocospanner);

    // 티
        EarlGrey = GameObject.Find("얼그레이");
        Btn_EarlGrey = EarlGrey.transform.GetComponent<Button>();
        Btn_EarlGrey.onClick.AddListener(Ck_EarlGrey);

        Chamomile = GameObject.Find("캐모마일");
        Btn_Chamomile = Chamomile.transform.GetComponent<Button>();
        Btn_Chamomile.onClick.AddListener(Ck_Chamomile);

        Peppermint = GameObject.Find("페퍼민트");
        Btn_Peppermint = Peppermint.transform.GetComponent<Button>();
        Btn_Peppermint.onClick.AddListener(Ck_Peppermint);

        GingerLemonTea = GameObject.Find("진저레몬티");
        Btn_GingerLemonTea = GingerLemonTea.transform.GetComponent<Button>();
        Btn_GingerLemonTea.onClick.AddListener(Ck_GingerLemonTea);

        PeachIceTea = GameObject.Find("복숭아아이스티");
        Btn_PeachIceTea = PeachIceTea.transform.GetComponent<Button>();
        Btn_PeachIceTea.onClick.AddListener(Ck_PeachIceTea);

        FreshLemonTea = GameObject.Find("생과일레몬티");
        Btn_FreshLemonTea = FreshLemonTea.transform.GetComponent<Button>();
        Btn_FreshLemonTea.onClick.AddListener(Ck_FreshLemonTea);

        GrapefruitTea = GameObject.Find("생과일자몽티");
        Btn_GrapefruitTea = GrapefruitTea.transform.GetComponent<Button>();
        Btn_GrapefruitTea.onClick.AddListener(Ck_GrapefruitTea);

        FruitsIceTea = GameObject.Find("FruitsIceTea");
        Btn_FruitsIceTea = FruitsIceTea.transform.GetComponent<Button>();
        Btn_FruitsIceTea.onClick.AddListener(Ck_FruitsIceTea);

        PeachBlossom = GameObject.Find("피치블로썸");
        Btn_PeachBlossom = PeachBlossom.transform.GetComponent<Button>();
        Btn_PeachBlossom.onClick.AddListener(Ck_PeachBlossom);

        PlumTea = GameObject.Find("자두티");
        Btn_PlumTea = PlumTea.transform.GetComponent<Button>();
        Btn_PlumTea.onClick.AddListener(Ck_PlumTea);

        VinChaud = GameObject.Find("뱅쇼");
        Btn_VinChaud = VinChaud.transform.GetComponent<Button>();
        Btn_VinChaud.onClick.AddListener(Ck_VinChaud);

        MilkTea = GameObject.Find("밀크티");
        Btn_MilkTea = MilkTea.transform.GetComponent<Button>();
        Btn_MilkTea.onClick.AddListener(Ck_MilkTea);

    // 에이드
        LemonAde = GameObject.Find("레몬에이드");
        Btn_LemonAde = LemonAde.transform.GetComponent<Button>();
        Btn_LemonAde.onClick.AddListener(Ck_LemonAde);

        GrapefruitAde = GameObject.Find("자몽에이드");
        Btn_GrapefruitAde = GrapefruitAde.transform.GetComponent<Button>();
        Btn_GrapefruitAde.onClick.AddListener(Ck_GrapefruitAde);

        LimeAde = GameObject.Find("라임에이드");
        Btn_LimeAde = LimeAde.transform.GetComponent<Button>();
        Btn_LimeAde.onClick.AddListener(Ck_LimeAde);

        GreenGrapeAde = GameObject.Find("청포도에이드");
        Btn_GreenGrapeAde = GreenGrapeAde.transform.GetComponent<Button>();
        Btn_GreenGrapeAde.onClick.AddListener(Ck_GreenGrapeAde);

        StrawberryAde = GameObject.Find("딸기에이드");
        Btn_StrawberryAde = StrawberryAde.transform.GetComponent<Button>();
        Btn_StrawberryAde.onClick.AddListener(Ck_StrawberryAde);

        PeachAde = GameObject.Find("복숭아에이드");
        Btn_PeachAde = PeachAde.transform.GetComponent<Button>();
        Btn_PeachAde.onClick.AddListener(Ck_PeachAde);

    // 디저트
        ChocolateChipCookie = GameObject.Find("초콜렛칩쿠키");
        Btn_ChocolateChipCookie = ChocolateChipCookie.transform.GetComponent<Button>();
        Btn_ChocolateChipCookie.onClick.AddListener(Ck_ChocolateChipCookie);

        DoubleChocoChipCookie = GameObject.Find("더블초코칩쿠키");
        Btn_DoubleChocoChipCookie = DoubleChocoChipCookie.transform.GetComponent<Button>();
        Btn_DoubleChocoChipCookie.onClick.AddListener(Ck_DoubleChocoChipCookie);

        MacadamiaCookie = GameObject.Find("마카다미아쿠키");
        Btn_MacadamiaCookie = MacadamiaCookie.transform.GetComponent<Button>();
        Btn_MacadamiaCookie.onClick.AddListener(Ck_MacadamiaCookie);

        PeanutButterCookie = GameObject.Find("피넛버터쿠키");
        Btn_PeanutButterCookie = PeanutButterCookie.transform.GetComponent<Button>();
        Btn_PeanutButterCookie.onClick.AddListener(Ck_PeanutButterCookie);

        BagelChipHoneyButter = GameObject.Find("베이글칩허니버터");
        Btn_BagelChipHoneyButter = BagelChipHoneyButter.transform.GetComponent<Button>();
        Btn_BagelChipHoneyButter.onClick.AddListener(Ck_BagelChipHoneyButter);

        BagelChipGarlicButter = GameObject.Find("베이글칩갈릭버터");
        Btn_BagelChipGarlicButter = BagelChipGarlicButter.transform.GetComponent<Button>();
        Btn_BagelChipGarlicButter.onClick.AddListener(Ck_BagelChipGarlicButter);

        StrawberryMacaron = GameObject.Find("딸기마카롱");
        Btn_StrawberryMacaron = StrawberryMacaron.transform.GetComponent<Button>();
        Btn_StrawberryMacaron.onClick.AddListener(Ck_StrawberryMacaron);

        SaltedCaramelMacaron = GameObject.Find("솔티카라멜마카롱");
        Btn_SaltedCaramelMacaron = SaltedCaramelMacaron.transform.GetComponent<Button>();
        Btn_SaltedCaramelMacaron.onClick.AddListener(Ck_SaltedCaramelMacaron);

        YellowCheeseMacaron = GameObject.Find("황치즈마카롱");
        Btn_YellowCheeseMacaron = YellowCheeseMacaron.transform.GetComponent<Button>();
        Btn_YellowCheeseMacaron.onClick.AddListener(Ck_YellowCheeseMacaron);

        ChocolateMacaron = GameObject.Find("초코마카롱");
        Btn_ChocolateMacaron = ChocolateMacaron.transform.GetComponent<Button>();
        Btn_ChocolateMacaron.onClick.AddListener(Ck_ChocolateMacaron);

        InjeolmiMacaron = GameObject.Find("인절미마카롱");
        Btn_InjeolmiMacaron = InjeolmiMacaron.transform.GetComponent<Button>();
        Btn_InjeolmiMacaron.onClick.AddListener(Ck_InjeolmiMacaron);

        OreoMacaron = GameObject.Find("오레오마카롱");
        Btn_OreoMacaron = OreoMacaron.transform.GetComponent<Button>();
        Btn_OreoMacaron.onClick.AddListener(Ck_OreoMacaron);



        Chuga = GameObject.Find("추가하기");
        Btn_Chuga = Chuga.transform.GetComponent<Button>();
        Btn_Chuga.onClick.AddListener(Ck_Chuga);

    }

// 상단메뉴
    public void Ck_Coffee()
    {
        int aa = 0;
        PlayerPrefs.SetInt("a", aa);
        a = PlayerPrefs.GetInt("a");
        Debug.Log(a);
    }

    public void Ck_Tea()
    {
        int aa = 1;
        PlayerPrefs.SetInt("a", aa);
        a = PlayerPrefs.GetInt("a");
        Debug.Log(a);
    }

    public void Ck_Ade()
    {
        int aa = 2;
        PlayerPrefs.SetInt("a", aa);
        a = PlayerPrefs.GetInt("a");
        Debug.Log(a);
    }

    public void Ck_Desert()
    {
        int aa = 3;
        PlayerPrefs.SetInt("a", aa);
        a = PlayerPrefs.GetInt("a");
        Debug.Log(a);
    }

// 중간메뉴
// 커피
    public void Ck_Americano()
    {
        int bb = 0;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_CafeLatte()
    {
        int bb = 1;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_HazelnutLatte()
    {
        int bb = 2;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_VanillaLatte()
    {
        int bb = 3;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_CinnamonLatte()
    {
        int bb = 4;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_DryCappuccino()
    {
        int bb = 5;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_DolceLatte()
    {
        int bb = 6;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_CaramelMaccihato()
    {
        int bb = 7;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_Einspanner()
    {
        int bb = 8;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_ChocoCafemoch()
    {
        int bb = 9;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_DalgonaLatte()
    {
        int bb = 10;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_Cocospanner()
    {
        int bb = 11;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    //티
    public void Ck_EarlGrey()
    {
        int bb = 0;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_Chamomile()
    {
        int bb = 1;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_Peppermint()
    {
        int bb = 2;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_GingerLemonTea()
    {
        int bb = 3;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_PeachIceTea()
    {
        int bb = 4;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_FreshLemonTea()
    {
        int bb = 5;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_GrapefruitTea()
    {
        int bb = 6;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_FruitsIceTea()
    {
        int bb = 7;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_PeachBlossom()
    {
        int bb = 8;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_PlumTea()
    {
        int bb = 9;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_VinChaud()
    {
        int bb = 10;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_MilkTea()
    {
        int bb = 11;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    //에이드
    public void Ck_LemonAde()
    {
        int bb = 0;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_GrapefruitAde()
    {
        int bb = 1;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_LimeAde()
    {
        int bb = 2;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_GreenGrapeAde()
    {
        int bb = 3;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_StrawberryAde()
    {
        int bb = 4;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_PeachAde()
    {
        int bb = 5;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    //디저트
    public void Ck_ChocolateChipCookie()
    {
        int bb = 0;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_DoubleChocoChipCookie()
    {
        int bb = 1;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_MacadamiaCookie()
    {
        int bb = 2;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_PeanutButterCookie()
    {
        int bb = 3;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_BagelChipHoneyButter()
    {
        int bb = 4;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_BagelChipGarlicButter()
    {
        int bb = 5;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_StrawberryMacaron()
    {
        int bb = 6;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_SaltedCaramelMacaron()
    {
        int bb = 7;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_YellowCheeseMacaron()
    {
        int bb = 8;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_ChocolateMacaron()
    {
        int bb = 9;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_InjeolmiMacaron()
    {
        int bb = 10;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }

    public void Ck_OreoMacaron()
    {
        int bb = 11;
        PlayerPrefs.SetInt("b", bb);
        b = PlayerPrefs.GetInt("b");
        Debug.Log(b);
    }


    public void Ck_Chuga()
    {
        array[0,0] = 2000;
        array[0,1] = 2500;
        array[0,2] = 2500;
        array[0,3] = 3000;
        array[0,4] = 3000;
        array[0,5] = 3000;

        int a1 = PlayerPrefs.GetInt("a");
        int b1 = PlayerPrefs.GetInt("b");

        Debug.Log(a1+","+b1);
        Debug.Log(array[a1, b1]);
        
        txtprice.text = array[a1, b1].ToString();

        sangsock = array[a1, b1];
        PlayerPrefs.SetInt("sangsock", sangsock);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
