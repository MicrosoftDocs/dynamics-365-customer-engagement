---
title: Actions supported in online and offline mode of Dynamics 365 for phones and tablets app
description: Learn about the prerequisites for accessing the mobile app in offline mode, features available in online and offline modes, and known issues in the offline mode. 
author: lavanyakr01
ms.author: lavanyakr
ms.topic: conceptual
ms.date: 02/22/2023
ms.custom: bap-template 
---

# Actions supported in online and offline mode

You can use the Sales Hub app on Dynamics 365 for mobile in offline mode when you're experiencing intermittent connectivity. Select the **Enable Mobile Offline** option in the app module properties to access the Sales Hub or Sales Professional app offline. 

> [!NOTE]
> Custom fields of all types are available to use when you're offline. For lookup fields, only downloaded records can be referenced.

Your administrator must have associated a mobile offline profile to your user record before you can work offline. The administrator can either use the **Sample Sales Scenario** mobile offline profile that's shipped out of the box, or create a profile. For more information, see [Set up mobile offline synchronization to allow users to work in offline mode on their mobile device](../mobile-app/setup-mobile-offline-for-admin.md).

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work offline on your mobile device](../mobile-app/work-in-offline-mode.md)

The following table lists the actions that are supported in online and offline mode for entities.

| Record type	| Actions supported online | Actions supported offline |
|---------|--------------------------|---------------------------|
| Appointment | - New<br>- Edit and save<br>- Mark Complete<br>- Close Appointment<br>- Process<br>- Email a link<br>- Convert to opportunity<br>- Delete<br>- Assign<br>- Word templates<br>- Add to Queue<br>- Queue Item Details<br>- Flow<br>- Word Templates<br>- Run Report | - New<br>- Edit and save<br>- Mark Complete<br>- Convert to opportunity<br>- Delete |
| Opportunity | - New<br>- Close as won<br>- Close as lost<br>- Recalculate Opportunity<br>- Create PDF<br>- Email as PDF<br>- Assign<br>- Email a link<br>- Delete<br>- Process<br>- Unfollow<br>- Flow<br>- Word Templates<br>- Run Report<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid)<br>- Add related contacts (through subgrid)<br>- Add activities (from timeline or through subgrid)<br>- Add notes (from timeline) | - New<br>- Close as won<br>- Close as lost<br>- Delete<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) |
| Account | - New<br>- Deactivate<br>- Connect<br>- Add to Marketing List<br>- Assign<br>- Email a Link<br>- Delete<br>- Create PDF<br>- Email as PDF<br>- Process<br>- Follow<br>- Flow<br>- Word Templates<br>- Edit and save<br>- Add related contacts (through subgrid)<br>- Add activities (from timeline or through subgrid)<br>- Add notes (from timeline) | - New<br>- Delete<br>- Edit and save |
| Contact | - New<br>- Deactivate<br>- Connect<br>- Add to Marketing List<br>- Assign<br>- Email a link<br>- Delete<br>- Process<br>- Follow<br>- Flow<br>- Word Templates<br>- Edit and save | - New<br>- Delete<br>- Edit and save |
| Lead | - New<br>- Delete<br>- Qualify<br>- Process<br>- Disqualify<br>- Assign<br>- Add to Marketing List<br>- Email a Link<br>- Follow<br>- Flow<br>- Word Templates<br>- Run Report<br>- Edit and save | - New<br>- Delete<br>- Qualify<br>- Disqualify<br>- Edit and save |
| Quote | - New<br>- Delete<br>- Look Up Address<br>- Activate Quote<br>- Create PDF<br>- Email as PDF<br>- Get Products<br>- Process<br>- Assign<br>- Email a Link<br>- Flow<br>- Word Templates<br>- Run Report<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) | - New<br>- Delete<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) |
| Order | - New<br>- Delete<br>- Create Invoice<br>- Create PDF<br>- Email as PDF<br>- Process<br>- Fulfill Order<br>- Cancel Order<br>- Recalculate<br>- Look Up Address<br>- Use Current Pricing<br>- Assign<br>- Email a Link<br>- Flow<br>- Word Templates<br>- Run Report<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) | - New<br>- Delete<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) |
| Invoice | - New<br>- Delete<br>- Look Up Address<br>- Invoice Paid<br>- Cancel Invoice<br>- Recalculate<br>- Get Products<br>- Lock Pricing<br>- Create PDF<br>- Email as PDF<br>- Process<br>- Assign<br>- Email as Link<br>- Flow<br>- Word Templates<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) | - New<br>- Delete<br>- Edit and save<br>- Add product lines (both existing products and write-in products, through subgrid) |
| Task | - Mark Complete<br>- Close Task<br>- Process<br>- Delete<br>- Email a Link<br>- Assign<br>- Add to Queue<br>- Convert To<br>- Queue Item Details<br>- Flow<br>- Word Templates<br>- Run Report<br>- Edit and save | - New<br>- Mark Complete<br>- Delete<br>- Edit and save<br>- Convert to Opportunity |
| Phone Call | - Mark Complete<br>- Close Phone Call<br>- Process<br>- Delete<br>- Email a Link<br>- Assign<br>- Add to Queue<br>- Convert To<br>- Queue Item Details<br>- Flow<br>- Word Templates<br>- Run Report<br>- Edit and save | - New<br>- Delete<br>- Edit and save |

## Known issues

This section lists the known issues with the offline mode of the Dynamics 365 for phones and tablets app.

-	**Business process flows**: Business process flows aren't supported for mobile offline. When you're offline, business process flows grids and views won't be available to be rendered on records that are opened in offline mode. If a record containing a business process flow was loaded prior to going offline, business process flow functions&mdash;such as move next or move previous&mdash;won't work. Business process flows support the ability to branch to a different set of stages, based on conditions defined on fields of the record. In offline mode, the conditions that determine the next set of stages in the business process flows won't be evaluated.

-	**Qualify a lead**: After you've created and qualified a lead in mobile offline, when you go back online the business process stage will still be shown as the qualify stage. You'll have to manually select **Next stage** to move the lead to next stage.

-	**Views**: Views aren't supported for the following entities in offline mode:
    -	Email
    -	Task
    -	Appointment
    -	Phone call
    
    Any views that have linked entities (related entity) that aren't available offline are also not supported.

-	Adding stakeholders, competitors, and sales teams to opportunities isn't supported in offline mode.

-	Product suggestions (when you're adding product lines to opportunities, quotes, orders, or invoices) aren't supported in offline mode.

-   Product property&ndash;related entities (DynamicProperty, DynamicPropertyInstance, DynamicPropertyOptionSetItem, and ProductSubstitute) aren't enabled for offline out of the box. These entities must be enabled for offline and added to an offline profile if you want to use product properties in offline mode.
