---
title: "Social Profile (SocialProfile) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Social Profile (SocialProfile) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Social Profile (SocialProfile) table/entity reference (Microsoft Dynamics 365)

This entity is used to store social profile information of its associated account and contacts on different social channels.

> [!NOTE]
> The Microsoft Dynamics 365 Social Profile (SocialProfile) table extends the [Microsoft Dataverse Social Profile (SocialProfile) table](/power-apps/developer/data-platform/reference/entities/socialprofile).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_customeroptout](#BKMK_msdyn_customeroptout)
- [msdyn_ocfollowercount](#BKMK_msdyn_ocfollowercount)
- [msdyn_ocfollowingcount](#BKMK_msdyn_ocfollowingcount)
- [msdyn_ocfriendcount](#BKMK_msdyn_ocfriendcount)
- [msdyn_phonenumber](#BKMK_msdyn_phonenumber)
- [msdyn_profileimagelink](#BKMK_msdyn_profileimagelink)

### <a name="BKMK_msdyn_customeroptout"></a> msdyn_customeroptout

|Property|Value|
|---|---|
|Description|**Flag specifying whether Customer has opted out of getting messages using this SP.**|
|DisplayName|**customeroptout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customeroptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_socialprofile_msdyn_customeroptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ocfollowercount"></a> msdyn_ocfollowercount

|Property|Value|
|---|---|
|Description|**Customer's Followers on the Social channel.**|
|DisplayName|**Follower Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfollowercount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ocfollowingcount"></a> msdyn_ocfollowingcount

|Property|Value|
|---|---|
|Description|**Customer's followings on the Social channel**|
|DisplayName|**Followings Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfollowingcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_ocfriendcount"></a> msdyn_ocfriendcount

|Property|Value|
|---|---|
|Description|**Customer's Friend count on the Social Channel**|
|DisplayName|**Friend Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfriendcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_phonenumber"></a> msdyn_phonenumber

|Property|Value|
|---|---|
|Description|**The phone number of the social profile.**|
|DisplayName|**Phone number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_profileimagelink"></a> msdyn_profileimagelink

|Property|Value|
|---|---|
|Description|**Link to the Customer's Social Channel Profile image.**|
|DisplayName|**Profile Image Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_profileimagelink`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_Community"></a> Community

Changes from [Community (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/socialprofile#BKMK_Community)

#### Community Choices/Options

|Value|Label|
|---|---|
|3|**Line**|
|4|**Wechat**|
|5|**Cortana**|
|6|**Direct Line**|
|7|**Microsoft Teams**|
|8|**Direct Line Speech**|
|9|**Email**|
|10|**GroupMe**|
|11|**Kik**|
|12|**Telegram**|
|13|**Skype**|
|14|**Slack**|
|15|**WhatsApp**|
|16|**Apple Messages For Business**|
|17|**Google's Business Messages**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid](#BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid)
- [socialprofile_cases](#BKMK_socialprofile_cases)

### <a name="BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid"></a> msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid](msdyn_ocliveworkitem.md#BKMK_msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_socialprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_socialprofile_msdyn_ocliveworkitem_socialprofileid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_socialprofile_cases"></a> socialprofile_cases

Many-To-One Relationship: [incident socialprofile_cases](incident.md#BKMK_socialprofile_cases)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`socialprofileid`|
|ReferencedEntityNavigationPropertyName|`socialprofile_cases`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010003501`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.socialprofile?displayProperty=fullName>
