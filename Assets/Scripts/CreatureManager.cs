using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {

        void Start()
        {
            List<Creature> creatures = new List<Creature> { new Kangaroo(), new Duck() };
            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();
            runnables.Add(new Kangaroo());
            jumpables.Add(new Kangaroo());
            runnables.Add(new Duck());
            swimmables.Add(new Duck());

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
        }

    }
}