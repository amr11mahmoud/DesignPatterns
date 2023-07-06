using Builder;

//
SmartFactory factory = new SmartFactory();

SmartSwitch smartSwitch = new SmartSwitch();

factory.Construct(smartSwitch);

factory.ShowProduct();


SmartPlug smartPlug = new SmartPlug();

factory.Construct(smartPlug);

factory.ShowProduct();