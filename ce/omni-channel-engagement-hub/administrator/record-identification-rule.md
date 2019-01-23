---
title: Configure record identification rule for work streams | MicrosoftDocs
description: See how you can configure record identification rules for work streams in the Omni-channel Engagement Hub
keywords: Configure record identification rules for work streams; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6da7ee5c-9e34-4f01-920c-6c381d2f4157
ms.custom: 
---

# Configure record identification rule

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Record identification rules help agents identify and assist customers better by showing their details on the **Customer summary** page. When an incoming conversation request is received, a notification appears that includes contextual information for the request. When an agent accepts the incoming notification, the **Customer summary** page opens, and shows the details of the customer and case. 

For more information, see [View Customer summary for an incoming engagement request](../agent/agent-csh/csh-view-customer-360-incoming-conversation-request.md).

> [!NOTE]
> For this preview, you can set up record identification rules while you create a new work stream. These rules are further mapped to a limited set of pre-chat survey questions. For more information, see step 3 of the [Create a new live chat work stream](work-streams.md#create-a-new-live-chat-work-stream) procedure. As a customer completes a pre-chat survey for an incoming conversation, the information can be used to identify the customer. 

## Configure a record identification rule in a work stream

Copy the following code snippet in the **Record Identification Rule** text box while creating a new work stream as given in [Create a new live chat work stream](work-streams.md#create-a-new-live-chat-work-stream) procedure. 

This snippet helps configure record identifications rules for the work stream.

```csharp
<RecordIdentificationRuleSet>
<RecordIdentificationRule>
<PrimaryEntity LogicalCollectionName="accounts" PrimaryKeyAttribute="accountid" PrimaryNameAttribute="name" />
<fetch version="1.0" output-format="xml-platform" mapping="logical" top="2">
<entity name="account">
<attribute name="accountid" />
<attribute name="name" />
<filter type="and">
<condition attribute="name" operator="eq" value="${Name}" />
<condition attribute="emailaddress1" operator="eq" value="${Email}" />
<condition attribute="telephone1" operator="eq" value="${Phone}"/>
</filter>
</entity>
</fetch>
<ContextKey name="msdyn_account_msdyn_ocliveworkitem_Customer" />
</RecordIdentificationRule>
<RecordIdentificationRule>
<PrimaryEntity LogicalCollectionName="contacts" PrimaryKeyAttribute="contactid" PrimaryNameAttribute="fullname" />
<fetch version="1.0" output-format="xml-platform" mapping="logical" top="2">
<entity name="contact">
<attribute name="contactid" />
<attribute name="fullname" />
<filter type="and">
<condition attribute="contactid" operator="eq" source="msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid" value="${msdyn_portalcontactid}" /> 
<condition attribute="fullname" operator="eq" value="${Name}" />
<condition attribute="emailaddress1" operator="eq" value="${Email}" />
<condition attribute="telephone1" operator="eq" value="${Phone}" />
</filter>
</entity>
</fetch>
<ContextKey name="msdyn_contact_msdyn_ocliveworkitem_Customer" />
</RecordIdentificationRule>
<RecordIdentificationRule>
<PrimaryEntity LogicalCollectionName="incidents" PrimaryKeyAttribute="incidentid" PrimaryNameAttribute="title" />
<fetch version="1.0" output-format="xml-platform" mapping="logical">
<entity name="incident">
<attribute name="incidentid" />
<attribute name="title" />
<filter type="and">
<condition attribute="ticketnumber" operator="eq" value="${CaseNumber}" />
</filter>
</entity>
</fetch>
<ContextKey name="msdyn_incident_msdyn_ocliveworkitem" />
</RecordIdentificationRule> 
</RecordIdentificationRuleSet>
```   

For each new work stream, update the condition variable values, and make sure that the names are unique and mapped to pre-chat questions (see the tables that follow). For example, if you create a work stream that is linked to the `Name1` and `Phone1` context variables, you must change the condition variable values from `{Name}` to `{Name1}` and from `{Phone}` to `{Phone1}`. 
             
For the preceding record identification rules to work, you **must** create the following questions for the pre-chat survey:

**Authenticated chat**

|Question name  |Answer type  |Question text |
|---------|---------|---------|
|CaseNumber    |     Multiple lines    |  Case Number         |
|    |         |         |

**Unauthenticated chat**

|Question name   |Answer type |Question text  |
|---------|---------|---------|
|CaseNumber     |    Multiple lines     |  Case Number        |
|Name      | Single line         |   Name       |
|Email      |    Single line      |  Email        |
|Phone      |  Single line       |   Phone      |
|    |         |         |

            
For information about how to create questions and use them in a pre-chat survey, see [Create a question library](create-question-library.md) and [Configure a pre-chat survey](configure-pre-chat-survey.md). 
            
> [!NOTE]
> Make sure that each question name is unique, and that it's used "as is" in the preceding code snippet. Otherwise, the record identification rule won't work. You can provide question text that meets your requirements.

### See also

[Create and manage work streams](work-streams.md)
