# 🧾 Grocery Receipt Generator

A C# (.NET Core 3.1) console application that simulates a grocery store
checkout system. The program collects item names and prices from the user,
stores them in parallel arrays, calculates a subtotal with tax, accepts a
cash payment, and prints a neatly formatted receipt with change.

---

## 📋 Features

- Collects up to 50 grocery items using parallel arrays for names and prices
- Validates all user input — re-prompts instead of crashing on bad input
- Rejects empty item names and negative prices
- Calculates subtotal, 8% sales tax, and grand total
- Accepts a cash payment and rejects insufficient amounts
- Calculates and displays change owed
- Prints a clean, column-aligned receipt to the console

---

## ⚙️ How It Works

1. The user enters how many items they are purchasing (1–50)
2. For each item, the user enters a name and a price
3. All names and prices are stored in parallel arrays
4. The program loops through the arrays to calculate the subtotal
5. Tax (8%) and grand total are computed from the subtotal
6. The user enters a cash payment — must be at least the total amount
7. Change is calculated and the full receipt is printed

---

## 💡 Example Usage
==============================
GROCERY RECEIPT ENTRY
How many items? (1–50): 3
--- Item 1 ---
Item name: Apples
Price ($): 2.50
--- Item 2 ---
Item name: Bread
Price ($): 3.99
--- Item 3 ---
Item name: Milk
Price ($): 4.79
Enter cash payment (minimum $12.14): $20.00
==============================
GROCERY RECEIPT
Apples                  $2.50
Bread                   $3.99
Milk                    $4.79
Subtotal:              $11.28
Tax (8%):               $0.90
TOTAL:                 $12.18
Cash Paid:             $20.00
CHANGE:                 $7.82

---

## 🛠️ Technologies Used

| Technology        | Purpose                                          |
|-------------------|--------------------------------------------------|
| C# 8.0            | Core programming language                        |
| .NET Core 3.1     | Runtime framework                                |
| Parallel Arrays   | Storing item names and prices in sync            |
| `double.TryParse` | Safe numeric input validation                    |
| `int.TryParse`    | Safe item count validation                       |
| `for` loop        | Iterating arrays to collect items and subtotal   |
| String Formatting | Column-aligned receipt output with `:C` currency |

---

## 🎓 Learning Outcomes

- Using parallel arrays to associate two related data sets
- Validating user input with `TryParse` to prevent crashes
- Looping on invalid input to re-prompt the user
- Performing multi-step financial calculations (subtotal → tax → total → change)
- Formatting console output with fixed-width columns for a receipt layout
- Separating concerns by extracting logic into named methods

---

## 📁 Folder Structure
E4-receipt-generator/
├── screenshots/
│   ├── item-entry.png
│   └── receipt-output.png
├── Program.cs
├── exam4.csproj
├── LICENSE
└── README.md

---

## 🚀 How to Run

### Prerequisites
- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet/3.1)

### Steps

```bash
# Clone the repository
git clone https://github.com/MissMarzelous/E4-receipt-generator.git

# Navigate into the project folder
cd E4-receipt-generator

# Run the application
dotnet run
```

---

## 📸 Screenshots

### Entering Items

![Item Entry](screenshots/e4-item-entry.png)

### Final Receipt

![Receipt Output](screenshots/e4-receipt-output.png)

---

## 👩‍💻 Author

**MissMarzelous** — C# .NET Core student project
