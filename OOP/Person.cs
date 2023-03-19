namespace OOP.Webinar.Pactics 
{ 
    public abstract class Person // Class & Interface By Default Internal Modifire
    {
           protected string Id;
             //এখানে দুটি বিষয়: ১. ফিল্ড ২. মেথড
           public  string name;
            // Field king of variable 
                // Field & Method By Default Private Modifire
                // 1. Public -- যে কেহ Access করতে পারবে।
                //2. Private --  শুধু বাউন্ডারির ভিতরে ব্যবহার করা যাবে।
                //3. Protected -- প্রাইভেট মত পাবই, আর পেরেন্ট বা বেস ক্লাসে এ পাব অন্য কোন ক্লাসে পাব না।
                //4. Internal -- Same Project a thakle paya jabe.
                /// <summary>
                /// 
                /// </summary>
           public  int age; 
                            // অন্য নাম ডাটা
                            // Funtion allways Returnable
                            // vb.net subro  otine Return করলে একটা আর ‍না করলে 
                            // মেথড এবং ফাংশন এর মধে তেমন কোন পার্থক্য নেই।
        public Person()
        {
            GeneratedId();
        }
       public  void Walk() // Void Method Non Returnable // Method Other Name Like Oparation 
        {
            Console.WriteLine("Walking" + Id);
        }
        public  void Talk() // 
        {
                Console.WriteLine("Tacking");
        }

            // Brief Encaptulation Isolation 
            // কাজটাকে ভাগ করে করা বোঝায়??


            //কোন ইম্পিমেনটেশন কে হাইড করা মানে Abstruction
           protected abstract void GeneratedId(); // o bastob 
    }
}