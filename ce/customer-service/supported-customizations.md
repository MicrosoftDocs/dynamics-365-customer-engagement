---
title: Customizations supported by the Conversation table and form
description: Learn about the customizations that you can and can't use with the Conversation table and form in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 05/30/2023
ms.custom: bap-template
---
# Customizations supported by the Conversation table and form

This article lists the customizations that you can and can't use with the **Conversation** table (`msdyn_ocliveworkitem`) and the **Conversation** form in Omnichannel for Customer Service.

## Customizations supported by the Conversation table

The following table lists the supported customizations.

| Components  | Add new?   | Edit existing?    |
|------------ | ---------  | ----------------  |
| Form        |  No        |  Yes            |
| View        |  Yes       |  No              |
| Chart       |  Yes       |  No               |
| Column      |  Yes       |  No. But you can change some properties of `msdyn_title` and `msdyn_thirdpartyconversations`. |
| Dashboard   |  No        |  No               |

You can:

- Create business rules.
- Associate a conversation with a lead or opportunity, or any other activity-enabled table via the **Regarding** column that's available for the conversation.
You can't:

You can't:

- Add a Many to Many relationship.
- Use custom columns in unified routing or assignment.

We recommend that:

- You don't add a custom column that's set as system required. If you intend to add such a custom column based on your business needs, then you populate the value for the custom column via sync pre-validation or pre-operation plug-in to ensure its value isn't null.
- You don't create alternate keys.

## Customizations supported by the Conversation form

If the [enhanced active conversation experience](add-customer-summary-settings.md) is enabled, you can customize the **Conversation** form to:

- Add subgrids on the Conversation form and view data for related tables in the subgrid.
- Load the **Active Conversation** form as an application tab instead of an anchor tab in a session.
- Edit existing forms in the following ways:
  - Add custom columns and allow saving of custom and standard columns on the form except some of the logical column names listed in the **Logical column** names section. 
  - Add custom controls. However, we recommend that you don't use custom controls to update a conversation because Omnichannel for Customer Service will overwrite the updates when the conversation ends.
  - Edit the quick view for customers and cases.
  - Add canvas apps, web resources, and external website controls.
  - Modify the form layout, resize controls, and create tabs and sections.
  - Edit the quick view for customers and cases.
  - Render columns with values on the form.
  - Configure **Customer 360** card and **Case details** card.
  - Move sections to different tabs.
  - Remove **Recent cases** subgrid.

We also recommend that you don't:

- Change the **Conversation** form or the order in which it's displayed, as it's the default form.
- Modify the out-of-the-box JavaScript handlers used in the **Active Conversation** form.

### Logical column names

Any updates to the following columns aren't supported:
- activityid
- msdyn_activeagentassignedon
- msdyn_activeagentid
- msdyn_activesessionparticipantid
- msdyn_cdsqueueid
- msdyn_channel
- msdyn_closedon
- msdyn_createdon
- msdyn_customerlanguageid
- msdyn_customerlocale
- msdyn_customersentimentlabel
- msdyn_effortpredictionresult
- msdyn_escalationcount
- msdyn_initiatedon
- msdyn_isoutbound
- msdyn_lastsessionid
- msdyn_liveworkstreamid
- msdyn_modifiedon
- msdyn_ocliveworkitemid
- msdyn_overflowtransfercount
- msdyn_queueid
- msdyn_queueitemid
- msdyn_startedon
- msdyn_statusupdatedon
- msdyn_title
- msdyn_transfercount
- msdyn_urcustomersentimentkeywords
- msdyn_urcustomersentimentlabel
- msdyn_urcustomersentimentscore
- msdyn_workstreamworkdistributionmode
- msdyn_wrapupinitiatedon
- ownerid
- statecode
- statuscode
- subject

### Next steps

[Customize Active Conversation form](customize-customer-summary.md)  
[Customize quick view forms](customize-quick-view-form.md)  
[Customize session forms](customize-session-form.md)  

### See also

[Conversation columns](developer/reference/entities/msdyn_ocliveworkitem.md)  
