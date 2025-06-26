Subscriber subscriber1 = new Subscriber();
subscriber1.FullName = "Луканин Захар Андреевич";
subscriber1.TalkTime = -1200;
subscriber1.TelephoneNumber = "89009002332";
subscriber1.Print();
Subscriber subscriber2 = new Subscriber();
subscriber2.Print();
Subscriber subscriber3 = new("Иванов Иван Иванович", "89009002332", 12);
subscriber3.Print();
Subscriber[] subscribers = {subscriber1, subscriber2, subscriber3};
int talkTime = 100;
string telephoneNumber = "89009002332";
Console.WriteLine();
Console.WriteLine("Время разговора: 100");
SearchSubscribers(subscribers, talkTime);
Console.WriteLine("Номер телефона: 89009002332");
SearchSubscriber(subscribers, telephoneNumber);

static void SearchSubscribers(Subscriber[] subscribers, int talkTime)
{
    foreach (Subscriber subscriber in subscribers)
        if (subscriber.TalkTime == talkTime)
            subscriber.Print();
}

static void SearchSubscriber(Subscriber[] subscribers, string telephoneNumber)
{
    foreach (Subscriber subscriber in subscribers)
        if (subscriber.TelephoneNumber == telephoneNumber)
            subscriber.Print();
}
