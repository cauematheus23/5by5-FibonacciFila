using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_FibonacciFila
{
    internal class QueueFibonacci
    {
        Integer head;
        Integer tail;
        public QueueFibonacci()
        {
            this.head = null;
            this.tail = null;
        }
        bool IsEmpty()
        {
            return head == null && tail == null;
        }
        public void Push(Integer aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                tail = aux;
            }
        }
        public void Print()
        {
            Integer aux = head;
            if (IsEmpty())
            {
                Console.WriteLine("Empty queue, nothing for print");
            }
            else
            {
                do
                {
                    Console.Write(" " + aux.ToString());
                    aux = aux.getNext();
                } while (aux != null);
            }
            Console.WriteLine();
        }
    }
}
