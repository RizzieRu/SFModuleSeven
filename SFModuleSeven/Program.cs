using SFModuleSeven.Models;

var customer = new Customer(1, "Кирилл", "Нечаев", "123", 0);

var employee = new Employee(2, "Андрей", "Арвихин");

var courier = new Courier(3, "Узулбек", "Мегатрон", 0, false, 0);

var address = new HomeDelivery("ул. Грешина, 13/5, 48, 3Б");

var order = new Order<HomeDelivery, string, string>(address, "in progress", "Cash", 1, customer, employee, courier);

order.Customer.MakeOrder();

if (order.Employee != null)
    order.Employee.MakeOrder();

if (order.Courier != null)
    order.Courier.MakeOrder();