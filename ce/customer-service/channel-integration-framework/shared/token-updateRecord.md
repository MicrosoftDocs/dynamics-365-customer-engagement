## Syntax

`microsoft-ciframework.updateRecord(entityLogicalName, id, data).then(successCallback, errorCallback);`

## Parameters

<table>
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
<td>The entity logical name of the record you want to update. For example: &quot;account&quot;.</td>
</tr>
<tr>
<td>id</td>
<td>String</td>
<td>Yes</td>
<td>GUID of the entity record you want to update.</td>
</tr>
<tr>
<td>data</td>
<td>String</td>
<td>Yes</td>
<td><p>String containing <code>key: value</code> pairs, where <code>key</code> is the property of the entity and <code>value</code> is the value of the property you want to update.</p>
<p>See examples later in this topic to see how you can define the <code>data</code> string for the update scenario.</td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td><p>A function to call when a record is updated.</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails.</td>
</tr>
</table>

## Return Value

On success, returns a promise containing a string with the updated attributes and their values.

## Examples

This sample code updates an existing contact record with record ID = a8a19cdd-88df-e311-b8e5-6c3be5a8b200

```JavaScript
//// define the data to update a record
var entityLogicalName = "contact";
var data = {
    "firstname": "Updated Sample",
    "lastname": "Contact",
    "fullname": "Updated Sample Contact",
    "emailaddress1": "contact@contoso.com",
    "jobtitle": "Sr. Marketing Manager",
    "telephone1": "555-0109",
    "description": "Updated values for this record were set programmatically."
}
// update contact record
var id = "b44d31ac-5fd1-e811-8158-000d3af97055";
var jsonData = JSON.stringify(data);
Microsoft.CIFramework.updateRecord(entityLogicalName,id,jsonData).then(
    function success (result) {
      res=JSON.parse(result);
          console.log("Contact updated with ID: " + res.id);
          //the record is updated
      },
      function (error) {
          console.log(error);
          //handle error conditions
      }
  );
```
