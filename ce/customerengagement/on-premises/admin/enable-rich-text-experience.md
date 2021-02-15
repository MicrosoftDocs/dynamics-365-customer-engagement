---
title: "Rich text experience for appointment activities | MicrosoftDocs"
description: "Enable the rich text experience for appointment activities."
ms.custom: 
ms.date: 10/28/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: Mattp123
ms.assetid: 502d88cd-3cf7-4611-b68e-15fcfddc19a5
caps.latest.revision: 15
ms.author: matp
manager: kvivek
---
# Rich text experience for appointment activities

When you enable the rich text experience, server-side synchronization and appointment activities support rich text. With the rich text editor, appointment descriptions can contain rich text. 

![Rich text appointment editor](media/appointment-rich-text.png)

With rich text enabled you get the following benefits:

- Create and synchronize appointments with rich text content in the description for an improved experience in both web and the Unified Interface. 
- Include content from an HTML web page right into the description field or create your own custom markup using the appointment editor. Appointments tracked from Outlook will also render rich text content in Dynamics 365 Customer Engagement (on-premises). 
- Server-side synchronization synchronizes the rich-text HTML content of appointment descriptions into Dynamics 365 Customer Engagement (on-premises).


> [!IMPORTANT]
> To enable rich text, your Dynamics 365 Customer Engagement (on-premises) version must be Dynamics 365 Customer Engagement (on-premises) version 9.0, or a later version.
> 
> After enabling, if you choose to disable the setting, the appointment editor  description field will reset to the plain-text field. Previously synchronized  appointments’ description will still contain rich-text HTML markup.
>
> Although the rich text editor can be used with appointment activities, it can’t be used with recurring appointments. When an appointment that contains rich text is converted to a recurring appointment, the description field for the activity is converted to a plain-text field containing rich text content.

## Enable the rich text editor for appointments
To enable the rich text editor on appointments, you need to configure the AppointmentRichEditorExperience organization setting for your Dynamics 365 Customer Engagement (on-premises) instance by running the PowerShell sample below. 

The PowerShell cmdlets require the Dynamics 365 Customer Engagement (on-premises) Microsoft.Xrm.Data.PowerShell module. The sample below includes the cmdlet to install the module. 

```powershell
#Install the module
Install-Module Microsoft.Xrm.Data.PowerShell -Scope CurrentUser

# Connect to the organization
Connect-CrmOnPremDiscovery -InteractiveMode #(or Connect-CrmOnlineDiscovery -InteractiveMode)

# Retrieve the organization entity
$entities = $organizationEntity = Get-CrmRecords -conn $conn -EntityLogicalName organization -Fields appointmentricheditorexperience -TopCount 1
$organizationEntity = $entities.CrmRecords[0]

Write-Host "Appointment RTE existing value: " $organizationEntity.appointmentricheditorexperience

# Set the appointmentricheditorexperience field
$organizationEntity.appointmentricheditorexperience = $true #(or $false)

# Update the record
Set-CrmRecord -conn $conn -CrmRecord $organizationEntity  
$entities = $organizationEntity = Get-CrmRecords -conn $conn -EntityLogicalName organization -Fields appointmentricheditorexperience -TopCount 1
$organizationEntity = $entities.CrmRecords[0]

Write-Host "Appointment RTE updated value: " $organizationEntity.appointmentricheditorexperience
```


## See also
[Create or edit an appointment](../basics/create-edit-appointment.md)





[!INCLUDE[footer-include](../../../includes/footer-banner.md)]