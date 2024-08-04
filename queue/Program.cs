namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> que = new(6);
            WorkCal workCal = new WorkCal();
            que.Enqueue(4);
            que.Enqueue(4);
            que.Enqueue(12);
            que.Enqueue(10);
            que.Enqueue(2);
            que.Enqueue(10);


            WorkCal.Cal(que);

        }

    }
    public class WorkCal
    {
        public void Cal()
        {
            Queue<int> que = new(6);

            int work = 8;
            int dayWork = que.Peek();
            Console.WriteLine(dayWork);
         //   if(work >= que.PeeK())
         //           { }>>> dequeue
         //work - daywork = int lastwork


         //lastwork > 0
         //lastwork >= Peek() >>> dequeue


         //lastwork == 0
         //work >= Peek() >>> dequeue

         //lastwork < 0
         //work = work - (-lastwork)
         //work >= Peek() >>> dequeue
             }
    }


}
