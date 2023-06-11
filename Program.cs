using Datastaructureonstackandqueue;

namespace Datestatureonstack
{
    class programm
    {
        static void Main(string[] args)
        {
            stack stack = new stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Dispaly();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Dispaly();

            Listqueue listqueue = new Listqueue();
            listqueue.Enqueue(56);
            listqueue.Enqueue(30);
            listqueue.Enqueue(70);
            listqueue.Dispaly();
            listqueue.Dequeue();
           listqueue.Dispaly();


        }
    }
}