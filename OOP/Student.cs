
// namespce ডাকনাম ও পুরো নাম হলো 
// NameSpace যদি ভিন্ন হয় তাহলে ‍সেম নামে ক্লাডিকলার করা যায়
//using OOP.Webinar.Pactics;
// নিজের ঘরে নিজের নাম চলবে কিন্তু গ্লোবালি যদি নিজেকে জানাতে চাই তাহলে পুরো নাাম জানাতে হবে।


using OOP.Webinar.Pactics;

namespace OOPs
{
    public class Student : Person // Parent/ Person Base Class Inheritance করা বোঝায়?
    {
        // Protected করা জিনিস আমরা ইনহেরিট করা ক্লাসে পা
       public void Read()
        {
            name = "Hasan Mahmud";
            age = 25;
            Id= 1;
        }

    }
}
