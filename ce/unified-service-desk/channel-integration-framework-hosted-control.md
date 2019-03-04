---
title: "Channel Integration Framework (CIF) (Hosted Control) | MicrosoftDocs"
description: "Learn about using the Channel Integration Framework hosted control type to integrate channel providers into Unified Service Desk client application to experience the functionalities of the channel provider (softphone, chatbot, message (sms), chat)."
ms.custom: 
  - dyn365-USD
ms.date: 03/08/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: CD120606-2A4A-427A-913A-FE00821FA330
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---

# Channel Integration Framework (Hosted Control)

Use the **Channel Integration Framework** type of hosted control to integrate your channel provider with Unified Service Desk client application. You can create multiple Channel Integration Framework type of hosted control to host different channels. To learn more, see [Integrate channel provider using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md).

To create a Channel Integration Framework type of hosted control, see [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md)

## Predefined UII actions

The following actions are supported for this type of hosted control.

### Close

This action is used to close the hosted control.

### FireEvent  

Fires a user-defined event from this hosted control.  

|Parameter|Description|  
|---------------|-----------------|  
|name|Name of the user-defined event.|  

All subsequent name=value pairs become the parameters to the event. For more information about creating a user-defined event, see [Create a user-defined event](../unified-service-desk/create-user-defined-event.md).  

### MoveToPanel  

This action is used to move hosted controls between panels at runtime.  

|Parameter|Description|  
|---------------|-----------------|  
|app|Name of the hosted control to be moved.|  
|panel|Target panel for the hosted control.| 

### Popup  

Pops up a URL from the hosted control and runs the window navigation rules against it for routing the popup to the appropriate location.  

|Parameter|Description|  
|---------------|-----------------|  
|url|Routes a popup from this hosted control using this URL as if it were a popup requested from the displayed control.|  
|frame|The frame from which this popup originated.| 

### RunScript  

This action injects JavaScript into the main frame of the application.

|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|

### SetSize  
 
This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.  

|Parameter|Description|  
|---------------|-----------------|  
|width|The width of the hosted control.|  
|height|The height of the hosted control.| 

### SetUserCanClose  

Enables the user to close the hosted control by clicking the X icon at the top-right corner of the hosted control tab.  

|Parameter|Description|  
|---------------|-----------------|  
|UserCanClose|Set this to `true` to enable the user to close the hosted control. Otherwise, set false.|

### RaiseCifClientEvent

This action sends the data raised from the client-side event to the hosted control.

|Parameter|Description|  
|---------------|-----------------|  
|event| The client-side events from where you want to raise the data. |
|data| The data parameter takes eventData values.<br><br>Pass the data as a string that was received from the event by using replacement parameters. <br>`data = [[data]+]`.<br><br> Supported client-side events are as follows:<br> <ul> <li>[ClickToActEvent](channel-integration-framework-hosted-control.md#clicktoactevent)</li> <li>[SendKbArticleEvent](channel-integration-framework-hosted-control.md#sendkbarticleevent)</li> </ul> See the above mentioned client-side events for the eventData values to pass.|

### UpdateCifContext

This action sends the data from client to channel provider.

|Parameter|Description|  
|---------------|-----------------|  
| corrId |  |
| action | The parameter to accept or reject the promise object. It takes the value as `accept` or `reject`. |
| result |  |
| api |  |
## Predefined events

The following events are supported for this type of hosted control.

### ClickToActEvent

The `ClickToActEvent` event invoked when user selects the outbound communication (ClickToAct) field in a form.

You can also write custom controls to raise the Channel Integration ClickToAct window event and pass any eventData as the business requirement.

To learn more, see [onclicktoact](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onclicktoact)

### SendKbArticleEvent

The `SendKbArticleEvent` event is invoked when the user selects the **Send** button in the Knowledge Base control. The eventData are the URL and the title of KB article that you need to pass.

To learn more, see [onsendkbarticle](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onsendkbarticle)

### CreateRecord

Creates an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The logical name of the entity. |
| data | String defining the attributes and values for the new entity record. |
| corrId |  |

To learn more, see [createRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/createrecord)

### RetrieveRecord

Retrieves an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of the record you want to retrieve. |
| id | GUID of the entity record you want to retrieve. |
| options | OData system query options, **$select** and **$expand**, to retrieve your data.<br> <ul> <li>Use the **$select** system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using **$select**, all properties will be returned.</li> <li>Use the <b>$expand</b> system query option to control what data from related entities is returned. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the **$select** system query option in parentheses after the navigation property name. Use this for both *single-valued* and *collection-valued* navigation properties.</li> </ul> <br>You specify the query options starting with `?`. You can also specify multiple query options by using `&` to separate the query options. For example:<br>`?$select=name&amp;$expand=primarycontactid($select=contactid,fullname)` |

To learn more, see [retrieveRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/retrieverecord)

### UpdateRecord

Updates an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of the record you want to update.  |
| id | GUID of the entity record you want to update. |
| data | String containing `key: value` pairs, where `key` is the property of the entity and `value` is the value of the property you want to update. |

To learn more, see [updateRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/updaterecord)

### DeleteRecord

Deletes an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of the record you want to delete.  |
| data | String defining the attributes and values for the new entity record. |
| id | GUID of the entity record you want to delete. |

To learn more, see [deleteRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/deleterecord)

### GetEntityMetadata

Returns the entity metadata for the specified entity.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of entity.  |
| attributes | The attributes for which you want to get metadata. |

To learn more, see [getEntityMetadata (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/getentitymetadata)

### GetEnvironment

Gets the current Unified Interface app and page details. The details include appId, pageType, and recordId (If available).

There are no parameters for this event.

To see learn more, see [getEnvironment (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/getenvironment)

### OpenForm

Opens an entity form or a quick create form.

|Parameter|Description|  
|---------------|-----------------|
| entityFormOptions | Entity form options for opening the form.  |
| formParameters | A dictionary object that passes extra parameters to the form. Invalid parameters will cause an error.<br><br>For information about passing parameters to a form, see [Set field values using parameters passed to a form](/dynamics365/customer-engagement/developer/set-field-values-using-parameters-passed-form) and [Configure a form to accept custom querystring parameters](/dynamics365/customer-engagement/developer/configure-form-accept-custom-querystring-parameters) |

To learn more, see [openForm (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/openform)

### RenderSearchPage

Allows you to search among the records of a particular entity type. This API opens the Unified Interface entity page with the search field on it prepopulated with the search string that is passed as a parameter.

|Parameter|Description|  
|---------------|-----------------|
| entityFormOptions | The entity logical name of the record you want to query.  |
| searchString | String to search among the attributes of the entity records. |

To learn more, see [renderSearchPage (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/rendersearchpage)

### SearchAndOpenRecords

The method searches for the record from the communication widget during the inbound communication and opens the record.

|Parameter|Description|  
|---------------|-----------------|
| entityFormOptions | The entity logical name to search and open. |
| queryParmeters | OData system query options, **$select** and **$expand**, to retrieve your data.<ul> <li> Use the **$select** system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using **$select**, all properties will be returned.</li> <li>Use the **$expand** system query option to control what data from related entities is returned. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the **$select** system query option in parentheses after the navigation property name. Use this for both single-valued and collection-valued navigation properties.</li> </ul>You specify the query options starting with `?`. You can also specify multiple query options by using `&` to separate the query options.<br> For example: `?$select=name&$expand=primarycontactid($select=contactid,fullname) `|
| searchOnly |Set false to open the record in the Unified Interface page if the search record is a single record. Set false to open search page if the search result has multiple records and auto populate the search page with the tag value mentioned when search field is used in queryParmeters.<br><br>Set true only to get results of the search as a promise result and not open the record or search page. |

## See also



