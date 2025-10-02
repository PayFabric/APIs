# Level 2 and 3 Fields
Business, corporate, and purchasing cards are used just like personal credit and debit cards. However, these cards carry higher interchange rates because they offer employers high value (and costly) features such as enhanced reporting and statements. Many merchants can qualify for lower commercial rates  by collecting the more in‑depth Level 2 and Level 3 data with each commercial card transaction.

**Note**: Level 2/3 data will be dropped and will NOT be sent to EVO gateway if passed through for _Verify_ transaction.

## Example
When submitting a [Transaction](Objects.md#transaction) developers can incorporate Level 2 and Level 3 fields into the ``Document`` field of the Transaction object. Below is an example JSON transaction object that includes Level 2 and 3 fields.
```json
{
  "Amount": "3225.00",
  "Tender": "CreditCard",
  "Type": "Sale",
  "Customer": "ARRONFIT0005",

  ... ...

  "Document": {
    "Head": [
      { "Name": "CompanyName", "Value": "Aaron Fitz Electrical" },
      { "Name": "InvoiceNumber", "Value": "INV14-98870" },
      { "Name": "PONumber", "Value": "PUR14-009872" },
      { "Name": "DiscountAmount", "Value": "200.00" },
      { "Name": "DutyAmount", "Value": "0.00" },
      { "Name": "FreightAmount", "Value": "24.00" },
      { "Name": "HandlingAmount", "Value": "20.00" },
      { "Name": "TaxExempt", "Value": "N" },
      { "Name": "TaxAmount", "Value": "400.00" },
      { "Name": "ShipFromZip", "Value": "92806" },
      { "Name": "ShipToZip", "Value": "92806" },
      { "Name": "OrderDate", "Value": "080423" }, //supports date formates like MMddyy and yyyy-MM-dd HH:mm:ss
      { "Name": "VATTaxAmount", "Value": "" },
      { "Name": "VATTaxRate", "Value": "" }
    ],
    "Lines": [
      {
        "Columns": [
          { "Name": "ItemCommodityCode", "Value": "24X BIKE" },
          { "Name": "ItemProdCode", "Value": "B872" },
          { "Name": "ItemUPC", "Value": "B872" },
          { "Name": "ItemUOM", "Value": "SET" },
          { "Name": "ItemDesc", "Value": "Mountain Bicycle" },
          { "Name": "ItemAmount", "Value": "2000.00" },
          { "Name": "ItemCost", "Value": "112.00" },
          { "Name": "ItemDiscount", "Value": "100.00" },
          { "Name": "ItemFreightAmount", "Value": "12.00" },
          { "Name": "ItemHandlingAmount", "Value": "10.00" },
          { "Name": "ItemQuantity", "Value": "10" }
        ]
      },
      {
        "Columns": [
          { "Name": "ItemCommodityCode", "Value": "12X BIKE" },
          { "Name": "ItemProdCode", "Value": "B0654" },
          { "Name": "ItemUPC", "Value": "B0654" },
          { "Name": "ItemUOM", "Value": "SET" },
          { "Name": "ItemDesc", "Value": "City Bicycle" },
          { "Name": "ItemAmount", "Value": "2000.00" },
          { "Name": "ItemCost", "Value": "80.00" },
          { "Name": "ItemDiscount", "Value": "100.00" },
          { "Name": "ItemFreightAmount", "Value": "12.00" },
          { "Name": "ItemHandlingAmount", "Value": "10.00" },
          { "Name": "ItemQuantity", "Value": "20" }
        ]
      }
    ]
  }
}
```
## Usage
In order to achieve the best interchange rates, all fields should be submitted and cannot be `null`, except as noted.

The table below describes the required fields for Level 2 qualification.

| Fields             | How data must be entered|
| -------------------| :-----------------------|
| PONumber           | Must not be all spaces or zero.|
| TaxAmount          | No comma. Must be greater than zero when "TaxExempt" is "N". e.g. "4267.00".|
| DiscountAmount     | No comma. Must be equal to the sum of all items' discount amount.|
| DutyAmount         | No comma. Must be equal to the sum of all items' duty amount.|
| FreightAmount      | Optional field, however should be provided if applicable.<br>No comma. Must be equal to the sum of all items' freight amount.|
| CompanyName        | The company name of the customer.|

The table below describes the required fields for Level 3 qualification.

| Fields             | How data must be entered|
| -------------------| :-----------------------|
| ItemAmount         | Must not be all spaces or all zeros.  | 
| ItemCommodityCode  | Must not be all spaces or all zeros. Refer to the following document for your industry’s commodity code: [commodity_codes.pdf](https://github.com/PayFabric/APIs/files/10877909/commodity_codes.pdf)| 
| ItemProdCode       | Must not be all spaces or all zeros.   | 
| ItemCost           | Must not be all spaces or all zeros.|
| ItemDesc           | Must not be all spaces. |
| ItemDiscount       | Must not be all zeros if a discount amount exists. Must be all zeros if discount amount does not exist.|
| ItemQuantity       | Must not be all spaces or all zeros.|
| ItemUOM            | Must not be all spaces or all zeros.|
