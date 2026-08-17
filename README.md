# Pizza Maker

A complete **C# Windows Forms ordering application** that lets users build customized pizzas, calculate pricing, review multi-pizza orders, and save the finished order to a local text file.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/Windows%20Forms-Desktop-0078D4?style=flat-square&logo=windows11&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

Pizza Maker is a desktop practice project focused on event-driven UI development, application state, dynamic pricing, and separation of concerns. Users can create one or more customized pizzas, review the full order in a separate window, and save the order details for later reference.

The application separates its Windows Forms interface from reusable pizza models, business logic, and data-access code through a dedicated class library.

## Features

- Custom pizza-order builder
- Customer-name entry
- Multiple standard ingredient selections
- Multi-select specialty add-ons
- Crust selection including a gluten-free option
- Adjustable sauce quantity
- Adjustable cheese quantity
- Scheduled delivery date and time
- Custom pizza-box color using a color picker
- Real-time price calculation
- Support for multiple pizzas in one order
- Separate full-order review window
- Local text-file order export
- Recursive form reset logic
- Dedicated model, business-logic, and data-access layers

## Pricing

Each pizza starts with a base price of **$15.00**.

The application then calculates the final price dynamically:

- Standard ingredient: **+$0.50 each**
- Specialty add-on: **+$0.50 each**
- Gluten-free crust: **+$1.00**

The displayed price updates as selections change.

## Technology

| Area | Technology |
| --- | --- |
| Language | C# |
| Runtime | .NET 10 |
| Desktop UI | Windows Forms |
| Architecture | Windows Forms client + reusable class library |
| Persistence | Local text-file export |

## Project Structure

```text
PizzaMaker/
├── PizzaMaker/
│   ├── FrmPizzaMaker.cs
│   ├── FrmPizzaMaker.Designer.cs
│   ├── FrmOrderDetails.cs
│   ├── FrmOrderDetails.Designer.cs
│   ├── Program.cs
│   └── PizzaMaker.csproj
├── PizzaMakerClassLibrary/
│   ├── Models/
│   │   └── PizzaModel.cs
│   ├── Services/
│   │   ├── BusinessLogicLayer/
│   │   │   └── PizzaLogic.cs
│   │   └── DataAccessLayer/
│   │       └── PizzaDAO.cs
│   └── PizzaMakerClassLibrary.csproj
└── PizzaMaker.slnx
```

## Application Flow

1. Enter the customer name.
2. Select ingredients and specialty add-ons.
3. Choose the crust type.
4. Adjust sauce and cheese quantities.
5. Select a delivery time.
6. Choose a pizza-box color.
7. Review the calculated price.
8. Add the pizza to the current order.
9. Repeat the process for additional pizzas if needed.
10. Open the full-order view to review every pizza.
11. Save the completed order to a text file.

## Design Notes

The main form maintains the pizza currently being configured and updates its price as selections change. Once a pizza is added, it is passed through the business layer to the data-access layer, where the current order is maintained as a collection of `PizzaModel` objects.

The order-details window receives the complete order and displays each pizza's customer name, ingredients, specialty add-ons, crust, sauce and cheese levels, delivery time, box color, and price.

Order persistence is handled separately from the interface. `PizzaDAO` creates an `App_Data` directory when needed and writes the complete order to `PizzaOrder.txt`.

The form also includes recursive control-reset logic that walks through nested Windows Forms controls and restores text boxes, check boxes, list boxes, radio buttons, scroll bars, date selectors, and color controls to their initial state.

## Running the Project

### Requirements

- Windows 10 or Windows 11
- Visual Studio with .NET desktop development support, or the .NET 10 SDK

Clone the repository:

```bash
git clone https://github.com/IPFizzy/PizzaMaker.git
cd PizzaMaker
```

Open `PizzaMaker.slnx` in Visual Studio and run the `PizzaMaker` project.

From the command line, build the solution with:

```bash
dotnet build PizzaMaker.slnx
```

Run the Windows Forms application with:

```bash
dotnet run --project PizzaMaker/PizzaMaker.csproj
```

## Saved Orders

When an order is saved successfully, the application writes it to:

```text
App_Data/PizzaOrder.txt
```

The file contains the configuration and price of each pizza in the current order.

## Practice Project Context

This repository began as a focused desktop-development exercise and is preserved as a completed practice project. It demonstrates Windows Forms controls, event handlers, model-driven application state, dynamic calculations, multi-item order management, file output, and layered application design in a compact codebase.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
