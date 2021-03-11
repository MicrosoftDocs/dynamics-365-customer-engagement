---
title: Set up frontline workers into your organization
description: Allows admin to set up their frontline workers through the new Get Started page
author: xonatia
ms.service: dynamics-365-customerservice
ms.reviewer: krbjoran
ms.custom:
  - dyn365-fieldservice
ms.date: 04/01/2021
ms.topic: overview
 - field-service
ms.author: xolee
search.app:
  - D365CE
  - D365FS
---

# Set up Frontline Workers in your Organization

Frontline workers in Dynamics 365 Field Service are individuals in your organization who are primarily scheduled for on-site jobs and uses Dynamics 365 Field Service mobile application for their work. Their quick setup in Dynamics 365 Field Service is critical to organizations in order to ensure they can immediately start fixing problems at customer locations and completing service calls. Therefore, admins can now use a **single form** to set up frontline workers in their organizations with all the required permissions that will allow their frontline workers to be promptly equipped to use the Dynamics 365 Field Service mobile application and instantanteously be scheduled for work orders. 

With a single form, admins can: 
1. Set up one or more frontline workers in their organization with the appropriate [characteristics (skills and certifications)](https://docs.microsoft.com/dynamics365/field-service/set-up-characteristics), [territories](https://docs.microsoft.com/dynamics365/field-service/set-up-territories), time zone, [security roles](https://docs.microsoft.com/dynamics365/field-service/view-user-accounts-security-roles), [field security profiles](https://docs.microsoft.com/dynamics365/field-service/view-user-accounts-security-roles), and [mobile offline profile](https://docs.microsoft.com/dynamics365/field-service/mobile-power-app-system-offline). 
2. Validate the defaulted security role, field security profile, and mobile offline profile that is set for their frontline workers, which controls the data their frontline workers can see and access. If appropriate, admins can choose to update these permissions or add any custom security roles, field security profiles, or mobile offline profile.
3. Automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile application. 

After using the form to set up one or more frontline workers, admins can:

4. View a list of all of their frontline workers, including their name, e-mail address, and home address. 
5. Edit and update the details of individual frontline workers, including home address, security role, field security profile, and mobile offline profile. 

## Prerequisites 
- Your organization must have a Microsoft 365 [administrator account](https://www.microsoft.com/microsoft-365/business/office-365-administration?rtc=1).
- Each frontline worker must have a Dynamics 365 Field Service license assigned through the [Microsoft Admin Center](https://admin.microsoft.com). 

## Definitions 
**Characterisitics**: Defines a frontline worker's areas of expertise or certifications.

**Territories**: Defines a frontline worker's geographical regions, such as city, state, county, or postal code, to inform scheduling.

**Security Role**: Controls the types of data and record types a frontline worker can access and edit. This should be defaulted to **Field Service - Resource**.

**Field Security Profile**: Controls which fields a frontline worker sees for a record type. This should be defaulted to **Field Service - Resource**.

**Mobile Offline Profile**: Controls what data is downloaded to the Dynamics 365 Field Service mobile application in offline mode. Unpublished profiles will not appear until published. This should be defaulted to **Field Service - Mobile Offline Profile**. 

## Get started 

1. On the **Home** tab or **Get Started** tab (include links), admins can set up their frontline workers in their organization.

## Use the form 

1. On the **Set up your frontline workers** section, select **Set Up**. 

2. The **Quick Set Up: Frontline Workers** form will appear. 

3. In the **Users** section, admins can type in and select **one or more frontline workers** in their organizations. 

 > [!NOTE]
 > If setting up multiple frontline workers on this form, all of them will have the properties, such as Characterisitics, Territories, Time Zone, Security Role, Field Security Profile, and Mobile Offline Profile. This allows the ability to group your frontline workers by these properties. 

4. Type and select the **Characterisitcs** that your frontline workers has. This is an optional field. 

4a. If the **Characterisitcs** does not exist, select the drop down and select **+ New Characterisitcs**. A new form will appear and admins can define and create a new Characterisitcs for their frontline workers. Admins **will not** lose their work on the Quick Set Up: Frontline Workers form.

5. Type and select the **Territories** that your frontline workers has. This is an optional field. 

5a. If the **Territories** does not exist, select the drop down and select **+ New Territories**. A new form will appear and admins can define and create a new Territories for their frontline workers. Admins **will** lose their work on the Quick Set Up: Frontline Workers form.


## View frontline workers 

## Edit & update details of individual frontline workers 
