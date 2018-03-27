--
title: "Managing user licenses for the Resco (Woodford) solution (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 03/21/2018
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
manager: "shellyha"
---


# Managing user licenses for the Resco (Woodford) mobile solution

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

If you’re the global admin at an organization with the Resco (Woodford) mobile solution installed, there are a few important differences between Dynamics 365 licenses and Resco mobile licenses for you to be aware of before assigning any licenses:

- Resco (Woodford) is a third-party solution that charges per user, per organization.
- Each field service license you purchase from Microsoft allows you to assign one Resco mobile license per user, with the total number of Resco mobile users allocated across all your production, sandbox, or trial organizations not to exceed the total number of field service licenses. 

    For example, if you purchase 100 field service licenses and you manage one production organization and one sandbox, you could assign Resco mobile licenses to 50 users at each organization for a maximum total of 100 users (not 100 users at *each* organization for a total of 200).

 - Resco mobile licenses purchased from Microsoft are allocated to one organization at a time, based on the organization ID.

## Activate Resco mobile licenses

First, you need to activate the licenses via the Resco (Woodford) website. [More information: Woodford User Guide](https://www.resco.net/woodford-user-guide/#__RefHeading__5781_1627906509)

>  Note: A 30-day trial automatically starts when you install the Resco (Woodford) solution for your field service organization. Activate the licenses before the trial period ends, or you won’t be able to access the Resco (Woodford) configuration tool until paid licenses are allocated.

## Allocate Resco mobile licenses across organizations
After you activate the Resco mobile licenses, you need to file a support ticket with the Microsoft support team, who then allocates your Resco mobile licenses across your organizations for you. 

1.  Go to the [Microsoft support
    page](https://go.microsoft.com/fwlink/?linkid=854120). 
2.  On the incident page, for **Problem type** choose **FieldOne Licensing**. For **Category** choose **License
    request**. Then select **Start Request**.
3.  On the contact information page, enter your details, and then select **Continue**.
4.  For **Incident Title**, enter **Field Service App Mobile License Activation
    Request**. In the **Tell us more about your issue** box, enter the following
    information:

    -   Customer company name
   
    -   Customer's public facing website

    -   Requesting person's full name

    -   Requesting Person's Email Address

    -   Requesting Person's phone Number

    -   Office 365 Admin Center License screenshot showing the number of Field
        Service licenses in your tenant. Here's how to get this info:

        -   As a **Global Office 365 Administrator**, open your **Office 365** portal
            and navigate to the **Admin Center**.

        -   Expand the **Billing** tab, and click on **Licenses**.

        -   Take a screenshot showing the number of field service licenses in
            your tenant.

    -   Enter your **unique org ID**. Here's how to find your org ID:

        -   As a **system Administrator**, open your Dynamics 365 instance.

        -   Navigate to **Settings \> Customizations \>Developer Resources**.

        -   In the Instance Reference Information section of the page, locate
            the Org ID.

        -   Click on **Submit**. An incident ticket is then raised to Microsoft. You will be provided with the Support Request Number and also with Response time. 
        
        -   You can track the incident request online at (https://support.microsoft.com/my/supportrequests). You can see the Severity of your case, providing as much information as you can could increase the Severity level of the case.          

>   [!NOTE] You can enter all of the above information in the space provided, or in the
>   space below enter “see attached” and save the information to an Excel
>   document and upload it with the service request. For example, create a table
>   in Excel using the information above.

>   If you have more than one instance that you need Resco mobile licenses for,
>   make sure to include the org ID for each instance, including the number of
>   mobile licenses needed for each instance.
