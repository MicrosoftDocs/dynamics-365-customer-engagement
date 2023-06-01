## Syntax

`Microsoft.CIFramework.openForm(entityFormOptions,formParameters).then(successCallback,errorCallback);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| entityFormOptions | JSON object | Yes | Entity form options for opening the form. The object contains the following attributes: <br> - cmdbar <br> - createFromEntity <br> - entityId <br> - entityName <br> - formId <br> - height <br> - navBar <br> - openInNewWindow <br> - windowPosition <br> - processId <br> - processInstanceId <br> - relationship <br> - selectStageId <br> - useQuickCreateForm <br> - width <br> See the [`entityFormOptions` object table](#entityFormOptionstable) for information about the attributes. |
|formParameters|Object|No|A dictionary object that passes extra parameters to the form. Invalid parameters will cause an error. <br>For information about passing parameters to a form, see [Set field values using parameters passed to a form](/power-apps/developer/model-driven-apps/set-field-values-using-parameters-passed-form) and [Configure a form to accept custom querystring parameters](/power-apps/developer/model-driven-apps/configure-form-accept-custom-querystring-parameters). |
|successCallback | Function | No | A function to execute when the operation succeeds.|
| errorCallback | Function | No | A function to execute when the operation fails.|
| | | |

<a name="entityFormOptionstable"></a>
## `entityFormOptions` object attributes

The following table describes the attributes of the `entityFormOptions` parameter.
> [!Note]
> The attributes are optional.

| Attribute name  | Type | Description |
|-----------------|----------|  -----------|
|cmdBar  | Boolean  | Indicates whether to display the command bar. If you do not specify this parameter, the command bar is displayed by default. |
|createFromEntity  |  Lookup  | Indicates a record that will provide default values based on mapped attribute values. The lookup object has the following properties of type String: `entityType`, `id`, and `name` (optional).|
| entityId | String | Identifier of the entity record to display the form for. |
| entityName |String | Logical name of the entity to display the form for.|
|formId  |  String |  Identifier of the form instance to be displayed.|
|  height| Number  |  Height of the form window to be displayed in pixels.|
|navBar  | String | Controls whether the navigation bar is displayed and whether application navigation is available using the areas and subareas defined in the site map. Valid values are: <br>`on`: The navigation bar is displayed. This is the default behavior if the `navBar` parameter is not used. <br>`off`: The navigation bar is not displayed. The user can navigate using other user interface elements or the back and forward buttons. <br>`entity`: On an entity form, only the navigation options for related entities are available. After navigating to a related entity, a back button is displayed on the navigation bar to allow returning to the original record. <br>  |
| openInNewWindow | Boolean | Indicates whether to display the form in a new window.|  
| windowPosition | Number |  Indicates the position of the form on the window. Valid values are: `1` for center position and `2` for side position. |
|processId | String |  Identifier of the business process to be displayed on the form. |
|processInstanceId | String |  Identifier of the business process instance to be displayed on the form.|
|relationship | JSON object |  Indicates a relationship object to display the related records on the form. See the [`relationship` object table](#relationshiptable) for information about the attributes. |
|selectStageId | String|  Identifier of the selected stage in business process instance.|
| useQuickCreateForm| Number |  Width of the form window to be displayed in pixels.|
| | | 

<a name="relationshiptable"></a>
## `relationship` object attributes

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


## Return value

On success, returns a Promise object containing string.




## Example

The following sample code opens a new incident form with prepopulated values for certain fields like contact ID and description.

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