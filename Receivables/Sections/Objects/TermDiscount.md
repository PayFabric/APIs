## Term Discount
The term discount object represents a discount to be applied to an invoice if it is paid within the term allotted. This object will be included as a child attribute of other JSON objects (such as [Invoice](Invoice.md)).

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| DiscountDate | DateTime | N | Timestamp indicating when this discount should be discarded. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| DiscountAvailableAmount | Decimal | N | Available discount amount | 19, 5 |
| Name | String | Y | Name of the discount | 50 |
