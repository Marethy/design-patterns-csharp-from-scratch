using Composite;

// Các sản phẩm lẻ (Leaf)
var cpu = new Product("CPU", 400m);
var gpu = new Product("GPU", 800m);
var ram = new Product("RAM", 150m);
var ssd = new Product("SSD", 200m);

var mouse = new Product("Mouse", 50m);
var keyboard = new Product("Keyboard", 100m);
var monitor = new Product("Monitor", 300m);

// Bundle cấp 1: bộ phận PC
var pcComponents = new ProductBundle(
    "PC Components",
    new List<ICartItem> { cpu, gpu, ram, ssd },
    discount: 50m
);

// Bundle cấp 1: phụ kiện
var peripherals = new ProductBundle(
    "Peripherals",
    new List<ICartItem> { mouse, keyboard, monitor },
    discount: 20m
);

// Bundle cấp 2: bộ PC hoàn chỉnh (gồm components + peripherals)
var fullPC = new ProductBundle(
    "Full PC",
    new List<ICartItem> { pcComponents, peripherals },
    discount: 100m
);

// Bundle cấp 3: mega pack (Full PC + 1 màn hình rời)
var megaPack = new ProductBundle(
    "Mega Pack",
    new List<ICartItem> { fullPC, new Product("Extra Monitor", 250m) },
    discount: 150m
);

// In ra kết quả
Console.WriteLine(pcComponents);
Console.WriteLine(peripherals);
Console.WriteLine(fullPC);
Console.WriteLine(megaPack);
