---
title: "Define custom state model transitions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: Learn about defining custom state model transitions for the Incident (Case) entity or custom entities.
ms.custom:
ms.reviewer: pehecke

ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to:
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 5c2a584a-b52a-4bf9-8952-b48418422d10
caps.latest.revision: 15
author: JimDaly
ms.author: jdaly
search.audienceType:
  - developer
---

# Define custom state model transitions

You can specify custom state transitions for the `Incident` (**Case**) entity or custom entities. The <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsStateModelAware> property is `true` for entities that support state model transitions.

Custom state transitions are an optional level of filtering to define which state transitions are valid for a record in a given state. Particularly when you have a large number of combinations for valid states and status values, defining a limited list of options can make it easier for people to choose the correct status for a record.

<a name="BKMK_StateModel"></a>

## What is the state model?

Entities that support the concept of state have a pair of attributes that capture this data, as shown in this table.

| Logical Name | Display Name      | Description                                                                                                                                                                                                                                    |
| ------------ | ----------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `statecode`  | **Status**        | Represents the state of the record. For custom entities this is **Active** or **Inactive**. The Incident (case) entity uses **Active**, **Resolved**, and **Canceled**. You can’t add more state options but you can change the option labels. |
| `statuscode` | **Status Reason** | Represents a status that is linked to a specific state. Each state must have at least one possible status. You can add additional status options and change the labels of existing options.                                                    |

The metadata for the attributes defines what status values are valid for a given state. For example, for the `Incident` (**Case**) entity, the default state and status options are shown in the following table.

| State                                        | Status                                                                           |
| -------------------------------------------- | -------------------------------------------------------------------------------- |
| `Label`: **Active**<br /><br /> `Value`: 0   | `Label`: **In Progress**<br /><br /> `Value`: 1<br /><br /> `State`: 0           |
| `Label`: **Active**<br /><br /> `Value`: 0   | `Label`: **On Hold**<br /><br /> `Value`: 2<br /><br /> `State`: 0               |
| `Label`: **Active**<br /><br /> `Value`: 0   | `Label`: **Waiting for Details**<br /><br /> `Value`: 3<br /><br /> `State`: 0   |
| `Label`: **Active**<br /><br /> `Value`: 0   | Label: **Researching**<br /><br /> `Value`: 4<br /><br /> `State`: 0             |
| `Label`: **Resolved**<br /><br /> `Value`: 1 | `Label`: **Problem Solved**<br /><br /> `Value`: 5<br /><br /> `State`: 1        |
| `Label`: **Resolved**<br /><br /> `Value`: 1 | Label: **Information Provided**<br /><br /> `Value`: 1000<br /><br /> `State`: 1 |
| Label: **Canceled**<br /><br /> `Value`: 2   | `Label`: **Canceled**<br /><br /> `Value`: 6<br /><br /> `State`: 2              |
| Label: **Canceled**<br /><br /> `Value`: 2   | `Label`: **Merged**<br /><br /> `Value`: 2000<br /><br /> `State`: 2             |

This data is stored in the <xref:Microsoft.Xrm.Sdk.Metadata.StatusOptionMetadata> class, which represents the options in the <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata> class.

[!INCLUDE[metadata_browser](../includes/metadata-browser.md)]

<a name="BKMK_DetectValidStatusTransitions"></a>

## Detect valid status transitions

You can modify the `statuscode` attribute to define which other status options represent valid transitions from the current status. For instructions, see the Customization Guide topic: [Define status reason transitions](</previous-versions/dynamicscrm-2016/administering-dynamics-365/dn660979(v=crm.8)>)

When custom state transitions are applied to an entity, the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.EnforceStateTransitions> property will be `true`. Also, each <xref:Microsoft.Xrm.Sdk.Metadata.StatusOptionMetadata> within the <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadata.Options> collection will have a new <xref:Microsoft.Xrm.Sdk.Metadata.StatusOptionMetadata.TransitionData> property. This property will contain a String value that represents an XML document. This document contains the definition of the allowed transitions. For example, the default `Incident` (**Case**) `StatusCode` attribute option may have the following `TransitionData` value.

```xml
<allowedtransitions xmlns="https://schemas.microsoft.com/crm/2009/WebServices">
<allowedtransition sourcestatusid="1" tostatusid="6" />
<allowedtransition sourcestatusid="1" tostatusid="1000" />
<allowedtransition sourcestatusid="1" tostatusid="2000" />
<allowedtransition sourcestatusid="1" tostatusid="5" />
</allowedtransitions>
```

> [!NOTE]
> When this data is retrieved in unmanaged code from the web service, for example when using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)], it will be escaped and appear like the following example.

```
&lt;allowedtransitions xmlns="https://schemas.microsoft.com/crm/2009/WebServices"&gt;
&lt;allowedtransition sourcestatusid="1" tostatusid="6" /&gt;
&lt;allowedtransition sourcestatusid="1" tostatusid="1000" /&gt;
&lt;allowedtransition sourcestatusid="1" tostatusid="2000" /&gt;
&lt;allowedtransition sourcestatusid="1" tostatusid="5" /&gt;
&lt;/allowedtransitions&gt;
```

When this data is present and the Entity `EnforceStateTransitions` property is `true`, any incident instance can only be changed to one of the allowed `statuscode` values. You can use<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update%2A> to set the `statuscode`<xref:Microsoft.Xrm.Sdk.OptionSetValue> to any of the allowed values that don’t represent a change in state. To change the state, use <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> setting the allowed <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest.State> and <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest.Status> property values or the <xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest> setting <xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest.Status> property to one of the values allowed for the current `statuscode` value. Attempting to set an invalid value throws an error.

### See also

[Sample: Retrieve Valid Status Transitions](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp/RetrieveValidTransitions)  
 [Record state and status](introduction-entities.md#bkmk_RecordStateandStatus)  
 [Retrieve and Detect Changes to Metadata](retrieve-detect-changes-metadata.md)

 <!--[Define status reason transitions](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn660979(v=crm.8))-->

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
