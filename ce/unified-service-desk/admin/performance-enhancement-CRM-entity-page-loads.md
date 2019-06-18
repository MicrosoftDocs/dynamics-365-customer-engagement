---
title: "Performance enhancement for CRM entity page loads | MicrosoftDocs"
description: "Learn about Internet Explorer pooling feature, which creates a dynamic pool of Internet Explorer process instances. The hosted control that you open uses an Internet Explorer instance from the pool to perform faster inline navigation."
ms.custom: 
  - dyn365-USD, dyn365-admin
ms.date: 02/06/2018
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: FA8D5702-C698-42B0-89BF-CD444BF3FB73
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---
# Performance enhancement for loading Customer Engagement app pages

::: moniker range="<=dynamics-usd-4"

You can experience enhanced performance of Dynamics 365 Customer Engagement apps entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with the Internet Explorer Pooling feature. 

::: moniker-end

::: moniker range=">=dynamics-usd-4.1"

You can experience enhanced performance of Dynamics 365 Customer Engagement apps entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with the pooling feature.

The pooling feature is available for the following processes:

- IE Process

- Chrome Process

::: moniker-end

## Pool process instances for IE Process

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Internet Explorer instances for hosted controls to use. Opening a hosted control using a pooled Internet Explorer instance enhances the performance of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

> [!Note]
> - The Internet Explorer pooling feature supports only CRM entity pages hosted in CRM page hosted control.
> - When you enable the pooling feature and open a CRM page hosted control, you can see in Task Manager that [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] creates a number of Internet Explorer process instances for hosted controls to use. 
> - The performance of the Internet Explorer pooling feature is dependent on the resources available on the client computer.

### Enable pooling for IE Process

By default, Internet Explorer pooling is disabled. To enable pooling, a System Administrator must configure the option on the **Active UII Options** page and set it to **true**.

To enable Internet Explorer pooling:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. Select **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **InternetExplorerPooling** for the **Name** field.

7. Set **True** for the **Value** field.

8. Select **Save**.

   ![Enable InternetExplorerPooling option](../../unified-service-desk/media/crm-itpro-usd-options-internetexplorerpooling.PNG "Enable InternetExplorerPooling option")

::: moniker range=">=dynamics-usd-4.1"

## Pool process instances for Chrome Process

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Chrome Process instances for hosted controls to use. Opening a hosted control using a pooled Chrome Process instance enhances the performance of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, the Chrome Process instance pooling is enabled.

With the Chrome Process instance pooling, every entity page navigation happens inline after the first entity page navigation.

#### Enable pooling for Chrome Process

By default, Chrome Process pooling is enabled. To disable the pooling, a System Administrator must configure the **ChromeProcessPooling** option on the **Active UII Options** page and set it to **False**.

To disable Chrome Process pooling:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. Select **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **ChromeProcessPooling** for the **Name** field.

7. Set **True** for the **Value** field.

8. Select **Save**.

### Skip inline entity navigation in Chrome Process pooling

If you want to skip the inline navigation for certain entities such as incident, account, and contact, then add the **BlockChromeProcessPooling** UII option and enter the entity names as the comma separated values (CSV). For example: **incident,account,contact**. To learn more, see [Add the BlockChromeProcessPooling UII option](#add-the-blockchromeprocesspooling-uii-option)

#### Add the BlockChromeProcessPooling UII option

To skip inline navigation for certain entities, a system Administrator must configure the option on the **Active UII Options** page and the entity names as the comma separated values (CSV).

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. Select **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **BlockChromeProcessPooling** for the **Name** field.

7. Enter the entity names as comma separated values (CSV) for the **Value** field. For example, **incident,account,contact**.

8. Select **Save**.

### Block second navigation in Chrome Process pooling

When an application (hosted control) is initialized and you do an inline navigation to another entity page using the same application (hosted control), then the second navigation is also inline. If you've specific window navigation rule between the same entity type with the **Route Window** action and **In Place** type, then the window navigation rule triggers the rule in a loop causing Unified Service Desk to crash. 

For example, with Chrome Process pooling, if you've set window navigation rule to navigate from an account tab to another account tab, with the **Route Window** action and **In Place** type, then window navigation rule loops in a recursive manner causing Unified Service Desk to crash.

To avoid the crash of Unified Service Desk, you can perform the following:

- Remove or change the window navigation rule
- Add the **BlockChromeProcessSecondInlineNavigation** UII option

#### Remove or change the window navigation rule

Window navigation rule for same entity navigation, you can remove or delete the window navigation rule itself as with the Chrome Process instance pooling, every entity page navigation happens inline after the first entity page navigation.

Window navigation rule for different entity navigation, you can change the window navigation rule to be more specific from which entity you want the navigation to happen. For example, you can set the window navigation rule from Contact or a Case entity to the Account entity type with the **Route Window** action and **In Place** type.

#### Add the BlockChromeProcessSecondInlineNavigation UII option

If you face challenges to change the window navigation rule, you can block the second inline navigation by adding the **BlockChromeProcessSecondInlineNavigation** UII option and set the value as **True**.

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. Select **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **BlockChromeProcessSecondInlineNavigation** for the **Name** field.

7. Set **True** for the **Value** field.

8. Select **Save**.

::: moniker-end

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)