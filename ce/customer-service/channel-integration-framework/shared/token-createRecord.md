## Syntax

`Microsoft.CIFramework.createRecord(entityLogicalName, data).then(successCallback, errorCallback);`

## Parameters

<table style="width:100%">
<tr>
<th>Name</th>
<th>Type</th>
<th>Required</th>
<th>Description</th>
</tr>
<tr>
<td>entityLogicalName</td>
<td>String</td>
<td>Yes</td>
<td>Logical name of the entity you want to create. For example: &quot;account&quot;.</td>
</tr>
<tr>
<td>data</td>
<td>String</td>
<td>Yes</td>
<td><p>String defining the attributes and values for the new entity record.</p>
</td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td><p>A function to call when a record is created.</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails.</td>
</tr>
</table>

## Return Value

On success, returns a promise containing a string with the attributes and their values.

## Examples

The sample code demonstrates to create a sample contact record.

```JavaScript
var entityLogicalName = "contact";
var data = {
    "firstname": "Sample",
    "lastname": "Contact",
    "fullname": "Sample Contact",
    "emailaddress1": "contact@contoso.com",
    "jobtitle": "Sr. Marketing Manager",
    "telephone1": "555-0109",
    "description": "Default values for this record were set programmatically."
}
// create contact record
var jsonData = JSON.stringify(data);
Microsoft.CIFramework.createRecord(entityLogicalName,jsonData).then(
    function success (result) {
      res=JSON.parse(result);
          console.log("Contact created with ID: " + res.id);
          //perform operations on record creation
      },
      function (error) {
          console.log(error);
          //handle error conditions
      }
  ); 
``` 

The below example shows how you can pass lookup value instead of plain text in the variable `data`.

```JavaScript
var data =
    {
        "name": "Sample Account",
        "primarycontactid@odata.bind": "/contacts(3518ddae-2f46-e911-8190-000d3a6ce16d)"
    }
var jsonData = JSON.stringify(data);
Microsoft.CIFramework.createRecord("account",jsonData).then(
    function success (result) {
      res=JSON.parse(result);
          console.log("Contact created with ID: " + res.id);
          //perform operations on record creation
      },
      function (error) {
          console.log(error);
          //handle error conditions
      }
);

```
