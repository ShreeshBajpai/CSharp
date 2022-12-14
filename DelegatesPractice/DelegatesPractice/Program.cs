using static DelegatesPractice.DelegatesOperations;

    Program obj = new Program();



    //------------normal function calling---------


    //obj.add(100, 200);
    //string msg = Program.Greetings("Abhay");
    //Console.WriteLine(msg);



    //----------instantiating delegate (delegate takes function as an argument)----------
    addDelegate ad = new addDelegate(Add);
    greetingsDelegate gd = new greetingsDelegate(Greetings);



    //---------invoking delegate----------------
    ad(498, 413);
    string s = gd("Shreesh");
    Console.WriteLine(s);



        //-----------instanriating generic delegate-------------



        Addnum1delegate obj1 = new Addnum1delegate(Addnumber1);
        double result1 = obj1.Invoke(12, 12.25f, 91.02);
        Console.WriteLine(result1);



        Addnum2delegate obj2 = new Addnum2delegate(Addnumber2);
        obj2.Invoke(10, 12.25f, 68.03);



        checkLendelegate obj3 = new checkLendelegate(checkLength);
        bool status = obj3.Invoke("Shreesh");
        Console.WriteLine(status);



        //--------we can use this below also code, instead of defining and instantiating the generic delegates -------
        /* Func<int, float, double, double> obj1 = new Func<int, float, double, double>(Addnumber1);
    double res = obj1.Invoke(10, 20.25f, 30.90);
    Console.WriteLine(res);



        Action<int, float, double> obj2 = new Action<int, float, double>(Addnumber2);
    obj2.Invoke(10, 10.23f, 64.0);



        Predicate<string> obj3 = new Predicate<string>(checkLength);
    bool status = obj3.Invoke("Shreesh");
    Console.WriteLine(status); */
        