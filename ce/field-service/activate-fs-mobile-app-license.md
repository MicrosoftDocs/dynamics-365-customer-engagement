---
title: "Activate field service mobile licenses (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: "dyn365-fieldservice"
ms.date: 03/27/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "activate-fs-mobile-app-license"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shellyhaverkamp"
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: "krbjoran"
ms.manager: "shellyhaverkamp"
---

# Activate field service mobile licenses 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Global admins preparing to use the [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] application must activate mobile licenses to have access to the field service mobile app. There are a few important details to know before you activate [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] mobile licenses:

- Field service mobile licenses are allocated to one organization at a time, based on the organization ID.

- Each [!include[Dynamics 365 for Field Service](../includes/pn-dyn-365-field-service.md)] license you purchase from Microsoft allows you to assign one mobile license per user, with the total number of mobile users allocated across all your production, sandbox, and trial organizations not to exceed the total number of licenses you purchased. 

    For example, if you purchase 100 field service licenses and you manage one production organization and one sandbox, you could assign mobile licenses to 50 users at both organizations for a maximum total of 100 mobile users (not 100 mobile users at *each* organization for a total of 200).

- A 30-day trial automatically starts when you install the Woodford solution in your Dynamics 365 instance. Activate the licenses before the trial period ends to maintain access to the field service mobile app. 

## Activate field service mobile licenses via a support ticket

Follow these steps to submit a service request to activate your field service mobile licenses:

1. [Download and complete this Excel spreadsheet](http://download.microsoft.com/download/D/7/3/D73699AE-EB42-49DF-8E71-F741D2FB5B95/Field service mobile app license allocation form.xlsx) in preparation for completing the service request. 
2. Go to the [Microsoft support page](https://go.microsoft.com/fwlink/?linkid=854120). 
3. On the incident page, for **Problem type** choose **FieldOne Licensing**. For **Category** choose **License request**. Then select **Start Request**.
4. On the contact information page, enter your details, and then select **Continue**. 
5. On the issue description page, for **Incident title**, enter **Field Service App Mobile License Activation
    Request**. In the **Tell us more about your issue** box, enter the following:

    -   Company name for the organization
    -   Company's public facing website
    -   Requestor's full name
    -   Requestor's email 
    -   Requestor's phone Number
    -   Office 365 Admin Center License screenshot showing the number of field
        service licenses in your tenant. 
        > [!NOTE] 
        > Here's how to get the field service license info:
        >  - As an Office 365 global administrator, open the Office 365 portal and navigate to the Admin Center.
        >  - Expand the **Billing** tab, and then select **Licenses**.
        >  - Take a screenshot showing the number of field service licenses in your tenant.

    -   Enter the **unique org ID**. 
        > [!NOTE]
        > Here's how to find your org ID:
        >  - Open your Dynamics 365 instance.
        >  - Navigate to **Settings \> Customizations \>Developer Resources**.
        >  - In the Instance Reference Information section, locate the Org ID.

6. Upload the Excel spreadsheet you completed.
7. Select **Submit** to submit the support ticket to Microsoft. You'll receive a support request number and estimated response time.
8. Once the service request is processed and closed, the field service mobile licenses will be available in your Dynamics 365 instances.
        
You can track the status of the support ticket online at [support.microsoft.com/my/supportrequests](https://support.microsoft.com/my/supportrequests). 
