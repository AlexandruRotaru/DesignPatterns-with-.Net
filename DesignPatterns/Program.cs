using Common;
using Common.Interfaces;
using DecoratorPattern;
using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorators;
using DesignPatternsApplied;
using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Product;
using ObserverPattern.Subject;
using ObserverPattern.Observers;
using ObserverPattern.Interfaces;
using StrategyPattern;
using StrategyPattern.Ducks;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;
using StrategyPattern.Interfaces;
using CommandPattern.Invoker;
using CommandPattern.Receivers;
using CommandPattern.ConcreteCommands;
using CommandPattern.Command;
using AdapterPattern.Target;
using AdapterPattern.Client;
using AdapterPattern.Adapters;
using FacadePattern.Subsystem;
using FacadePattern.Facade;
using TemplateMethodPattern;
using IteratorPattern;
using IteratorPattern.Aggregator;
using CompositePattern.Component;
using CompositePattern.Composite;
using PancakeHouseMenu = IteratorPattern.ConcreteAggregator.PancakeHouseMenu;
using DinerMenu = IteratorPattern.ConcreteAggregator.DinerMenu;
using MenuItem = CompositePattern.Leaf.MenuItem;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IView view = new View();

            // UseStrategyPattern(view);

            // UseObserverPattern(view);

            // UseDecoratorPattern(view);

            // UseFactoryMethodPattern(view);

            // UseCommandPattern(view);

            // UseAdapterPattern(view);

            // UseFacadePattern(view);

            // UseTemplateMethod(view);

            // UseIteratorPattern(view);

            UseCompositePattern(view);

            view.Pause();
        }

        public static void UseStrategyPattern(IView view)
        {
            //the parts that vary
            IFlyBehavior mallardFlyBehavior = new FlyWithWings();
            IQuackBehavior mallardQuack = new MallardQuack();

            Duck mallard = new MallardDuck(mallardFlyBehavior, mallardQuack, view);

            MiniDuckSimulator duckSim = new MiniDuckSimulator(mallard);

            duckSim.Run();
        }

        public static void UseObserverPattern(IView view)
        {
            //Subject
            WeatherData weatherData = new WeatherData();

            //create and add one observer
            IObserver currentConditions = new CurrentConditionsDisplay(view, weatherData);

            weatherData.SetMeasurements(20.1f, 87, 1100);

            currentConditions.Unregister();
        }

        public static void UseDecoratorPattern(IView view)
        {
            Beverage espresso = new Espresso();
            view.DisplayMessage(espresso.GetDescription() + " $" + espresso.Cost());

            Beverage houseBlend = new HouseBlend();

            //decorate the object
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);

            view.DisplayMessage(houseBlend.GetDescription() + " $" + houseBlend.Cost());

            Beverage newEspresso = new Espresso();
            newEspresso = new Mocha(newEspresso);
            newEspresso = new Soy(newEspresso);
            newEspresso = new Whip(newEspresso);
            view.DisplayMessage(newEspresso.GetDescription() + " $" + newEspresso.Cost());
        }

        public static void UseFactoryMethodPattern(IView view)
        {
            PizzaStore nyStore = new NYStylePizzaStore(view);

            view.DisplayMessage("Orderring a NY cheese pizza: ");
            Pizza nyCheesePizza = nyStore.OrderPizza("cheese");
            view.DisplayMessage($"{nyCheesePizza.GetName()} is ready");

            view.DisplayMessage(string.Empty);

            view.DisplayMessage("Orderring a NY pepperoni pizza: ");
            Pizza nyPepperoniPizza = nyStore.OrderPizza("pepperoni");
            view.DisplayMessage($"{nyPepperoniPizza.GetName()} is ready");

            view.DisplayMessage(string.Empty);

            PizzaStore chicagoStore = new ChicagoStylePizzaStore(view);

            view.DisplayMessage("Orderring a Chicago veggie pizza: ");
            Pizza chicagoCheesePizza = chicagoStore.OrderPizza("veggie");
            view.DisplayMessage($"{chicagoCheesePizza.GetName()} is ready");
        }

        public static void UseCommandPattern(IView view)
        {
            RemoteControl remote = new RemoteControl(view);

            Light livingRoomLight = new Light(view, "Living Room");
            Light kitchenLight = new Light(view, "Kitchen");

            //CeilingFan ceilingFan = new CeilingFan(view, "Kitchen");

            Garage garage = new Garage(view);
            Stereo stereo = new Stereo(view);

            ICommand livigRommLightOn = new LightOnCommand(livingRoomLight);
            ICommand livigRommLightOff = new LightsOffCommand(livingRoomLight);
            ICommand KitchenLightOn = new LightOnCommand(kitchenLight);
            ICommand KitchenightOff = new LightsOffCommand(kitchenLight);

            ICommand garageDoorOpen = new GarageOpenCommand(garage);
            ICommand garageDoorClose = new GarageCloseCommand(garage);

            ICommand stereoWithCd = new StereoWithCDCommand(stereo);
            ICommand stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, livigRommLightOn, livigRommLightOff);
            remote.SetCommand(1, KitchenLightOn, KitchenightOff);
            remote.SetCommand(2, garageDoorOpen, garageDoorClose);
            remote.SetCommand(3, stereoWithCd, stereoOff);

            remote.DisplayButtons();

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);
        }

        public static void UseAdapterPattern(IView view)
        {
            SomeDuck duckling = new SomeDuck(view);

            WildTurkey turkey = new WildTurkey(view);

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            view.DisplayMessage("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            view.DisplayMessage("The duck says...");
            TestDuck(duckling);

            view.DisplayMessage("The turkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }

        public static void UseFacadePattern(IView view)
        {
            Amplifier amp = new Amplifier(view);
            BlueRayPlayer blue = new BlueRayPlayer(view);
            PopcornPopper pop = new PopcornPopper(view);
            Projector projector = new Projector(view);
            Screen screen = new Screen(view);
            TheaterLights lights = new TheaterLights(view);

            HomeTheaterFacade facade = new HomeTheaterFacade(amp, blue, projector, lights, screen, pop, view);

            facade.WatchMovie("LOTR");
            view.DisplayMessage(string.Empty);
            facade.EndMovie();
        }

        public static void UseTemplateMethod(IView view)
        {
            CaffeineBeverage tea = new Tea(view);

            CaffeineBeverage coffee = new Coffee(view);

            tea.PrepareRecipe();
            view.DisplayMessage(string.Empty);
            coffee.PrepareRecipe();
        }

        public static void UseIteratorPattern(IView view)
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, view);

            waitress.PrintMenu();
        }

        public static void UseCompositePattern(IView view)
        {
            MenuComponent pancakeHouseMenu = new CompositePattern.Leaf.PancakeHouseMenu(view, "Pancake House Menu");
            MenuComponent desertMenu = new CompositePattern.Leaf.DessertMenu(view);
            MenuComponent dinerMenu = new CompositePattern.Composite.DinerMenu(view, "Diner Menu");
            
            MenuComponent allMenus = new Menu("All Menus", "All menus combined", view);

            desertMenu.Add(new MenuItem("Apple pie", "Apple pie with a flakey crust topped with vanilla icecream", true, 1.99, view));
            desertMenu.Add(new MenuItem("Fondue", "Lots o'chocolate", true, 2.99, view));

            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99, view));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausge", false, 2.99, view));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancake Breakfast", "Pancakes with fresh blueberries", true, 3.49, view));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles with blueberries or strawberries", true, 3.59, view));

            dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fackin') Bacon with lettuce & tomato on whole wheat", true, 2.99, view));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99, view));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29, view));
            dinerMenu.Add(new MenuItem("Hotdog", "A hotdog with relish, onions, ketchup.", false, 3.05, view));
            dinerMenu.Add(desertMenu);



            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);

            CompositePattern.Waitress waitress = new CompositePattern.Waitress(allMenus);
            waitress.PrintMenu();
        }
    }   
}
