## Syntax

`Microsoft.CIFramework.retrieveRecord(entityLogicalName, id, options).then(successCallback, errorCallback);`

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
<td>The entity logical name of the record you want to retrieve. For example: &quot;account&quot;.</td>
</tr>
<tr>
<td>id</td>
<td>String</td>
<td>Yes</td>
<td>GUID of the entity record you want to retrieve.</td>
</tr>
<tr>
<td>options</td>
<td>String</td>
<td>No</td>
<td><p>OData system query options, <b>$select</b> and <b>$expand</b>, to retrieve your data.</p>
<ul><li>Use the <b>$select</b> system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using <b>$select</b>, all properties will be returned.</li>
<li>Use the <b>$expand</b> system query option to control what data from related entities is returned. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the <b>$select</b> system query option in parentheses after the navigation property name. Use this for both <i>single-valued</i> and <i>collection-valued</i> navigation properties.</li>
</ul>
<p>You specify the query options starting with <code>?</code>. You can also specify multiple query options by using <code>&amp;</code> to separate the query options. For example:</p>
<code>?$select=name&amp;$expand=primarycontactid($select=contactid,fullname)</code>
</td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td><p>A function to call when a record is retrieved.</p>
</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to call when the operation fails.</td>
</tr>
</table>

## Return Value

On success, returns a promise containing a string with the retrieved attributes and their values.

## Examples

This sample code retrieves the name and phone number of a contact record with ID = `a8a19cdd-88df-e311-b8e5-6c3be5a8b200`.

```JavaScript
// retrieve contact record
var id = "b44d31ac-5fd1-e811-8158-000d3af97055";
var entityLogicalName = "contact";
Microsoft.CIFramework.retrieveRecord(entityLogicalName, id, "?$select=fullname,telephone1").then(
    function success(result) {
      res=JSON.parse(result);
        console.log(`Retrieved values: Full Name: ${res.fullname}, Telephone Number: ${res.telephone1}`);
        // perform operations on record retrieval
    },
    function (error) {
        console.log(error.message);
        // handle error conditions
    }
);
``` 
