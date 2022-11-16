## Syntax

`Microsoft.CIFramework.openForm(entityFormOptions,formParameters).then(successCallback,errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| entityFormOptions | Object | Yes | Entity form options for opening the form. The object contains the following attributes: <br> - cmdbar <br> - createFromEntity <br> - entityId <br> - entityName <br> - formId <br> - height <br> - navBar <br> - openInNewWindow <br> - windowPosition <br> - processId <br> - processInstanceId <br> - relationship <br> - selectStageId <br> - useQuickCreateForm <br> - width <br> See the [`entityFormOptions` object table](#entityFormOptionstable) for information about the attributes. |
|formParameters|Object|No|A dictionary object that passes extra parameters to the form. Invalid parameters will cause an error.|
| | | |

<a name="entityFormOptionstable"></a>

The following table describes the attributes of the `entityFormOptions` parameter.
> [!Note]
> The attributes are optional.

| Attribute name  | Type | Description |
|-----------------|----------|  -----------|
|cmdBar  | Boolean  | Indicates whether to display the command bar. If you do not specify this parameter, the command bar is displayed by default|
|createFromEntity  |  Lookup  | Indicates a record that will provide default values based on mapped attribute values. The lookup object has the following properties of type String: `entityType`, `id`, and `name` (optional).
| entityId | String | Identifier of the entity record to display the form for. 
| entityName |String | Logical name of the entity to display the form for.
|formId  |  String |  Identifier of the form instance to be displayed.|
|  height| Number  |  Height of the form window to be displayed in pixels.|
|navBar  | String | Controls whether the navigation bar is displayed and whether application navigation is available using the areas and subareas defined in the site map. Valid values are: <br>`on`: The navigation bar is displayed. This is the default behavior if the `navBar` parameter is not used. <br>`off`: The navigation bar is not displayed. The user can navigate using other user interface elements or the back and forward buttons. <br>`entity`: On an entity form, only the navigation options for related entities are available. After navigating to a related entity, a back button is displayed on the navigation bar to allow returning to the original record. <br>  |
| openInNewWindow | Boolean | Indicates whether to display the form in a new window.|  
| windowPosition | Number |  Indicates the position of the form on the window. Valid values are: `1` for center position and `2` for side position. |
|processId | String |  Identifier of the business process to be displayed on the form. |
|processInstanceId | String |  Identifier of the business process instance to be displayed on the form.|
|relationship | Object |  Indicates a relationship object to display the related records on the form. See the [`relationship` object table](#relationshiptable) for information about the attributes. |
|selectStageId | String|  Identifier of the selected stage in business process instance.|
| useQuickCreateForm| Number |  Width of the form window to be displayed in pixels.|
| | | 

<a name="relationshiptable"></a>

The following table describes the attributes of the `relationship` object attribute of the `entityFormOptions` parameter.
> [!Note]
> The attributes are optional.

| Attribute name  | Type | Description |
|-----------------|----------|  -----------|
| attributeName  |  String |  Name of the attribute used for relationship. |
|name | String | Name of the relationship. |
| navigationProperty | String | Name of the navigation property for the relationship. |
| relationshipType  | Number | Relationship type. Valid values are: `0` for one-to-many relationship and `1` for many-to-many relationship.|
| roleType  | Number | Role type in the relationship. Valid values are: `1` for referencing and `2` for AssociationEntity.  | 
| | | |



<table>
  <tr>
    <th>Name</th>
    <th>Type</th> 
    <th>Required</th>
    <th>Description</th>
  </tr>
  <tr>
    <td>entityFormOptions</td>
    <td>Object</td> 
    <td>Yes</td>
    <td>Entity form options for opening the form. The object contains the following attributes:<ul>
<li><b>cmdbar</b>: (Optional) Boolean. Indicates whether to display the command bar. If you do not specify this parameter, the command bar is displayed by default.</li>
<li><b>createFromEntity</b>: (Optional) Lookup. Designates a record that will provide default values based on mapped attribute values. The lookup object has the following String properties: <code>entityType</code>, <code>id</code>, and <code>name</code> (optional).</li>
<li><b>entityId</b>: (Optional) String. ID of the entity record to display the form for.</li>
<li><b>entityName</b>: (Optional) String. Logical name of the entity to display the form for.</li>
<li><b>formId</b>: (Optional) String. ID of the form instance to be displayed.</li>
<li><b>height</b>: (Optional) Number. Height of the form window to be displayed in pixels.</li>
<li><b>navBar</b>: (Optional) String. Controls whether the navigation bar is displayed and whether application navigation is available using the areas and subareas defined in the sitemap. Valid values are: &quot;on&quot;, &quot;off&quot;, or &quot;entity&quot;.<ul><li><code>on</code>: The navigation bar is displayed. This is the default behavior if the <b>navBar</b> parameter is not used.</li>
<li><code>off</code>: The navigation bar is not displayed. People can navigate using other user interface elements or the back and forward buttons.</li><li><code>entity</code>: On an entity form, only the navigation options for related entities are available. After navigating to a related entity, a back button is displayed in the navigation bar to allow returning to the original record.</li></ul></li>
<li><b>openInNewWindow</b>: (Optional) Boolean. Indicates whether to display form in a new window.</li>
<li><b>windowPosition</b>: (Optional) Number. Specify one of the following values for the window position of the form on the screen:<ul><li><code>1:center</code></li><li><code>2:side</code></li></ul>
<li><b>processId</b>: (Optional) String. ID of the business process to be displayed on the form.</li>
<li><b>processInstanceId</b>: (Optional) String. ID of the business process instance to be displayed on the form.</li>
<li><b>relationship</b>: (Optional) Object. Define a relationship object to display the related records on the form. The object has the following attributes.
</table>
  <tr>
    <th>Name</th>
    <th>Type</th> 
    <th>Description</th>
<tr>
<td>attributeName</td>
<td>String</td>
<td>Name of the attribute used for relationship.</td>
</tr>
<tr>
<td>name</td>
<td>String</td>
<td>Name of the relationship.</td>
</tr>
<tr>
<td>navigationPropertyName</td>
<td>String</td>
<td>Name of the navigation property for this relationship.</td>
</tr>
<tr>
<td>relationshipType</td>
<td>Number</td>
<td>Relationship type. Specify one of the following values:
<ul><li><code>0:OneToMany</code></li><li><code>1:ManyToMany</code></li></ul></td>
</tr>
<tr>
<td>roleType</td>
<td>Number</td>
<td>Role type in relationship. Specify one of the following values:
<ul><li><code>1:Referencing</code></li><li><code>2:AssociationEntity</code></li></ul></td>
</tr>
</table>
</li>
<li><b>selectedStageId</b>: (Optional) String. ID of the selected stage in business process instance.</li>
<li><b>useQuickCreateForm</b>: (Optional) Boolean. Indicates whether to open a quick create form. If you do not specify this, by default <b>false</b> is passed.</li>
<li><b>width</b>: (Optional) Number. Width of the form window to be displayed in pixels.</li>
</ul>
</tr>
<tr>
<td>formParameters</td>
<td>Object</td>
<td>No</td>
<td>A dictionary object that passes extra parameters to the form. Invalid parameters will cause an error.<br/><br/>For information about passing parameters to a form, see <a href="/dynamics365/customerengagement/on-premises/developer/set-field-values-using-parameters-passed-form" data-raw-source="[Set field values using parameters passed to a form](../../../customerengagement/on-premises/developer/set-field-values-using-parameters-passed-form.md)">Set field values using parameters passed to a form</a> and <a href="/dynamics365/customerengagement/on-premises/developer/configure-form-accept-custom-querystring-parameters" data-raw-source="[Configure a form to accept custom querystring parameters](../../../customerengagement/on-premises/developer/configure-form-accept-custom-querystring-parameters.md)">Configure a form to accept custom querystring parameters</a> </td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to execute when operation succeeds.
</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to execute when the operation fails.<br>
</td>
</tr>
</table>

## Return value

On success, returns a promise object containing string.

> [!Note]
> Use this method to open entity or quick create forms instead of the deprecated [Xrm.Utility.openEntityForm](/previous-versions/dynamicscrm-2016/developers-guide/jj602956(v=crm.8)#openentityform) and [Xrm.Utility.openQuickCreate](/previous-versions/dynamicscrm-2016/developers-guide/jj602956(v=crm.8)#openquickcreate) methods.


## Examples

The following sample code opens a new incident form with pre-populated values for certain fields like contact ID and description.

```JavaScript
var id = "5af02e2a-d0d1-e811-8158-000d3af97055"
var title = "Sample Case Form"
var entityFormOptions = {};
    entityFormOptions["entityName"] = "incident";
    
var formParameters = {};
    //pre-populate some fields based on the context
    formParameters["title"] = title;
    formParameters["customerid"] = id;
    formParameters["customeridtype"] = "contact";
    formParameters["caseorigincode"] = 1;
    formParameters["description"] = "Opened the form with pre-populated details like title, contact id, and description.";

//Open the form
Microsoft.CIFramework.openForm(JSON.stringify(entityFormOptions), JSON.stringify(formParameters)).then(
      function (success) {
        console.log(success);
    },
    function (error) {
        console.log(error);
    }
  );
```