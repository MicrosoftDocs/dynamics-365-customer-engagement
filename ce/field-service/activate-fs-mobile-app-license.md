---
title: "Manage Resco mobile licenses (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 03/27/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "activate-fs-mobile-app-license"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shellyha"
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: "krbjoran"
ms.manager: "shellyha"
---

# Manage Resco mobile licenses 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

If you’re the global admin at an organization with the [!INCLUDE[pn-resco-woodford](../includes/pn-resco-woodford.md)] mobile solution installed, there are a few important differences between [!include[Dynamics 365](../includes/pn-crm-2016-shortest.md)] licenses and [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses for you to be aware of before you assign any licenses:

- [!INCLUDE[pn-resco-woodford](../includes/pn-resco-woodford.md)] is a third-party solution that charges per user, per organization.

- [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses are allocated to one organization at a time, based on the organization ID.

- Each field service license you purchase from Microsoft allows you to assign one [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile license per user, with the total number of [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile users allocated across all your production, sandbox, or trial organizations not to exceed the total number of field service licenses you purchased. 

    For example, if you purchase 100 field service licenses and you manage one production organization and one sandbox, you could assign [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses to 50 users at both organizations for a maximum total of 100 users (not 100 users at *each* organization for a total of 200).

## Activate [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses

First, you need to activate the licenses via the [!INCLUDE[pn-resco-woodford](../includes/pn-resco-woodford.md)] website. [More information: Woodford User Guide](https://www.resco.net/woodford-user-guide/#__RefHeading__5781_1627906509)

[!NOTE]
> A 30-day trial automatically starts when you install the [!INCLUDE[pn-resco-woodford](../includes/pn-resco-woodford.md)] solution for your field service organization. Activate the licenses before the trial period ends, or you won’t be able to access the [!INCLUDE[pn-resco-woodford](../includes/pn-resco-woodford.md)] configuration tool until paid licenses are allocated by Microsoft support.

## Allocate [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses via a support ticket
After you activate the [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses, you need to file a support ticket with the Microsoft support team, who then allocates your [!INCLUDE[pn-resco](../includes/pn-resco.md)] mobile licenses across your organizations for you. 

1.  Go to the [Microsoft support
    page](https://go.microsoft.com/fwlink/?linkid=854120). 
2.  On the incident page, for **Problem type** choose **FieldOne Licensing**. For **Category** choose **License
    request**. Then select **Start Request**.
3.  On the contact information page, enter your details, and then select **Continue**.
4.  On the issue description page, for **Incident title**, enter **Field Service App Mobile License Activation
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
        > - As a **Global Office 365 Administrator**, open the **Office 365** portal
            and navigate to the **Admin Center**.
        >
        > - Expand the **Billing** tab, and then select **Licenses**.
        >
        > - Take a screenshot showing the number of field service licenses in
            your tenant.

    -   Enter the **unique org ID**. 
        > [!NOTE]
        > Here's how to find your org ID:
        >
        > - Open your Dynamics 365 instance.
        >
        > - Navigate to **Settings \> Customizations \>Developer Resources**.
        >
        > - In the Instance Reference Information section, locate
            the Org ID.

5.  Select **Submit** to submit the support ticket to Microsoft. You'll receive a support request number and estimated response time. 
        
You can track the incident request online at [support.microsoft.com/my/supportrequests](https://support.microsoft.com/my/supportrequests). 

After the request is completed, you can assign the licenses to users. More information: [Purchase and assign Dynamics 365 (online) licenses](https://docs.microsoft.com/dynamics365/customer-engagement/admin/purchase-assign-online-licenses)

[!NOTE]
> We've provided a downloadable Excel spreadsheet which you can fill in with the details and then upload with the support ticket, if you prefer. If you have more than one instance, include the org ID and the number of mobile licenses to be allocated for each one.
