---
title: "Frequently asked questions for Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 1/6/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: tw45
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Frequently asked questions for Dynamics 365 Field Service - General

> [!Note]
> If you're looking for help with **errors**, **unexpected behavior**, **crashes**, and **bugs**, create a [Dynamics 365 support ticket](https://dynamics.microsoft.com/contact-us/). 

## Why is Field Service missing from the sitemap navigation?

As of Field Service v8.x, you can find Field Service among the other Dynamics 365 apps by selecting Dynamics 365 in the top left and selecting **Field Service**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service in the navigation](./media/navigation-fs-sitemap.png)

This is different from previous versions (7.x and 6.x), where Field Service was found in the menu as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of the former Field Service navigation menu](./media/navigation-fs-sitemap-7.png)


## Can I customize out-of-the-box web resources, option sets, security roles, or workflows? 

No. Customizing, taking dependencies, or custom invocation of these components is not supported and could result in unintended system behaviors. Organizations that customize these components may not immediately cause the environment to break; but eventually, as Microsoft releases changes to the customized components, the changes will not be applied to the top layer of that component. The specific customized layer will override all future changes. This will almost certainly eventually cause the instances that have customized these components to experience unpredictable errors and behavior.  

## Why are there work orders with duplicate work order numbers?

This is a known issue that was fixed in Field Service version **8.6.0.274+** that lets you apply the Dynamics 365 auto numbering system to the work order entity. To do this you must: 

1.  Opt-in to the **Auto Numbering** function in **Field Service Settings**.
2.  Manage it in **Dynamics Settings** > **Administration** > **Auto-Numbering**.   

## Why can't cascade crew changes be disabled for a booking scheduled to a crew or group 

This happens when a booking is assigned from a resource (not crew or group) to a crew or group and the value of **msdyn_CascadeCrewChanges** in the booking is set to false. To overcome this, open the booking and set the value of **msdyn_CascadeCrewChanges** to **Yes**. Then, re-perform the booking assignment to a crew. This will fix the error the user sees when assigning the booking to a crew.

## Can I modify, edit, or delete Field Service date fields or statuses?

No. Modifying, editing, or deleting date fields and statuses can affect business logic and may disrupt solution upgrades. Examples of work order date fields include date window start, date window end, time from promised, and time to promised. Examples of status fields include work order system status and agreement system status.

## Why do I get the error message "This form can only be used on service-maintenance based records. Record is read only"

> [!div class="mx-imgBorder"]
> ![Screenshot of the error on the opportunity form](./media/faq-opportunity-read-only.png)

Field Service makes the opportunity, lead, quote, and invoice forms read-only once it detects the record is not a service-maintenance based record. This means Field Service forms or the forms copied from Field Service forms do not support opportunity, lead, quote, and invoice records other than Field Service opportunity, lead, quote, and invoice. If you want to use an opportunity form for non-Field Service related opportunities, use the out-of-the-box opportunity (**Opportunity: Opportunity**) form shipped by Dynamics 365 Sales or copy this form for further customization. The same is true for lead, quote, and invoice.

## Why do I get an AttributeMap error when upgrading and how do I fix it?  

You may have encountered 1 of these 2 errors during upgrade: 

- "An AttributeMap, with Id: GUID, between attribute customerid and msdyn_serviceaccount of entity incident and msdyn_workorder, has an unmanaged base instance and therefore cannot be updated by a managed solution."
- "An AttributeMap, with Id: GUID, between attribute customerid and msdyn_billingaccount of entity incident and msdyn_workorder, has an unmanaged base instance and therefore cannot be updated by a managed solution."

You can resolve this issue by following the steps outlined below. These attributemaps will be automatically recreated by upgrading to a newer version. Review these two attributemaps and delete them in your environment.

### Error with customerid and msdyn_serviceaccount

1. Go to **Settings** > **Customization** > **Customize the System**.
2. Go to **Entities** > **Work Orders** > **N:1 Relationships**.
3. Double-click on the row called **msdyn_account_msdyn_workorder_ServiceAccount**.
4. Select **Mappings**.
5. Select the **Service Account** mapping and delete it.
6. Run upgrade again.


> [!div class="mx-imgBorder"]
> ![Screenshot showing the troubleshooting pathway outlined in the previous steps in the customization settings](./media/faq-attributemap-upgrade-error-service-account.png)

### Error with customerid and msdyn_billingaccount

1. Go to **Settings** > **Customization** > **Customize the System**.
2. Go to **Entities** > **Work Orders** > **N:1 Relationships**.
3. Double-click on the row called **msdyn_account_msdyn_workorder_BillingAccount**.
4. Select **Mappings**.
5. Select the **Billing Account** mapping and delete it.
6. Run upgrade again.


> [!div class="mx-imgBorder"]
> ![Screenshot showing the troubleshooting pathway outlined in the previous steps in the customization settings](./media/faq-attributemap-upgrade-error-billing-account.png)

## See also

- [Resource Scheduling Optimization FAQs](rso-faq.md)
- [Field Service Mobile FAQs](activate-fs-mobile-app-license.md)
- [Get help for Field Service Mobile](mobile-get-help.md)









