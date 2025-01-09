---

title: Pooling speeds up model-driven app pages in Unified Service Desk
description: Use pooling in Unified Service Desk to improve the performance of model-driven app page loading in Edge WebView2, Chrome, or IE processes.
ms.date: 03/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom:
  - dyn365-USD
  - dyn365-admin
ai.usage: ai-assisted

---

# Load app pages faster with pooling in Unified Service Desk

::: moniker range="=dynamics-usd-4.2"

To make your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] more responsive and efficient, use the pooling feature. Pooling allows you to reuse processes for loading app pages in model-driven apps instead of creating new ones every time. Reuse of existing processes improves app performance and reduces the memory consumption and startup time of your pages. The pooling feature is available for the following processes:

- Microsoft Edge WebView2 process
- Google Chrome process
- IE process

## Pool process instances for Edge WebView2 process

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Edge WebView2 process instances for hosted controls to use. Opening a hosted control using a pooled Edge WebView2 process instance enhances the performance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, the Edge WebView2 process instance pooling is enabled.

With Edge WebView2 process instance pooling, every entity page navigation happens inline after the first entity page navigation.

### Enable pooling for Edge WebView2 process

By default, Edge Webview2 Process pooling is enabled. To disable pooling, the System Administrator must configure the **EdgeWebView2Pooling** option on the **Active UII Options** page and set it to **False**.

**To disable Edge WebView2 process pooling**

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **EdgeWebView2Pooling**.

8. In the **Value** field, select **True**.

9. Select **Save**.

### Skip inline entity navigation in Edge WebView2 process pooling

If you want to skip the inline navigation for certain entities such as incident, account, and contact, then add the **BlockEdgeWebView2PoolingForEntities** UII option and enter the entity names as comma-separated values, as described in the following section.

#### Add the BlockEdgeWebView2PoolingForEntities UII option

To skip inline navigation for certain entities, you must configure the option on the **Active UII Options** page and add the entity names as comma-separated values.

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **BlockEdgeWebView2PoolingForEntities**.

8. In the **Value** field, enter the entity names as comma-separated values; for example, **incident,account,contact**.

9. Select **Save**.

### Hide command bar in Edge WebView2 process

In Edge WebView2 process, the command bar is always shown on the pooled Edge WebView2 process instances. If you want to hide the command bar on the Dynamics 365 pages that are loaded in the Edge WebView2 process instances, then you can add the **HideCommandBarEdgeWebView2** UII option.

### Show nav bar in Edge WebView2 process

In Edge WebView2 process, the nav bar is always hidden on the pooled Edge WebView2 process instances. If you want to show the nav bar on the Dynamics 365 pages that are loaded in the Edge WebView2 process instances, then you can add the **ShowNavBarEdgeWebView2** UII option.

### Block second navigation in Edge WebView2 process pooling

When an application (hosted control) is initialized and you do an inline navigation to another entity page using the same application (hosted control), then the second navigation also happens inline. If you have a specific window navigation rule between the same entity type with the **Route Window** action and **In Place** type, then the window navigation rule loops in a recursive manner, causing Unified Service Desk to crash.

For example, with Edge WebView2 process pooling, if you've set window navigation rule to navigate from an account tab to another account tab, with the **Route Window** action and **In Place** type, then window navigation rule loops in a recursive manner, causing Unified Service Desk to crash.

To prevent Unified Service Desk from crashing, you can do one of the following:

- Remove or change the window navigation rule
- Add the **BlockEdgeWebView2ProcessSecondInlineNavigation** UII option

<a name="remove-change-window-nav-edge-webview2"></a>

#### Remove or change the window navigation rule

**Window navigation rule for same entity navigation**: You can remove or delete the window navigation rule because with Edge WebView2 process instance pooling, every entity page navigation happens inline after the first entity page navigation.

**Window navigation rule for different entity navigation**: You can change the window navigation rule to be more specific about which entity you want the navigation to originate from. For example, you can set the window navigation rule from a Contact or a Case entity to the Account entity type, by using the **Route Window** action and **In Place** type.

#### Add the BlockEdgeWebView2ProcessSecondInlineNavigation UII option

By default, second inline navigation is blocked when using Edge WebView2 process&mdash;that is, the option is enabled by default. However, if you want to allow the second inline navigation&mdash;in other words, disable the option&mdash;create the **BlockEdgeWebView2ProcessSecondInlineNavigation** UII option and set the value as **False**.

After adding the UII option, if you set the value as **True**, then the option is enabled and will block the second inline navigation.

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **BlockEdgeWebView2ProcessSecondInlineNavigation**.

8. In the **Value** field, select **True**.

9. Select **Save**.

::: moniker-end

::: moniker range="=dynamics-usd-4.1"

You can experience enhanced performance of entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with the pooling feature.

The pooling feature is available for the following processes:

- IE process

- Chrome process

::: moniker-end

::: moniker range="dynamics-usd-4"

You can experience enhanced performance of entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with the Internet Explorer Pooling feature.

::: moniker-end

::: moniker range=">=dynamics-usd-4.1"

## Pool process instances for Chrome process

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Chrome process instances for hosted controls to use. Opening a hosted control using a pooled Chrome process instance enhances the performance of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, the Chrome process instance pooling is enabled.

With the Chrome process instance pooling, every entity page navigation happens inline after the first entity page navigation.

### Enable pooling for Chrome process

By default, Chrome process pooling is enabled. To disable pooling, you must configure the **ChromeProcessPooling** option on the **Active UII Options** page and set it to **False**.

**To disable Chrome process pooling**

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **ChromeProcessPooling**.

8. In the **Value** field, select **False**.

9. Select **Save**.

### Skip inline entity navigation in Chrome process pooling

If you want to skip the inline navigation for certain entities such as incident, account, and contact, add the **BlockChromeProcessPooling** UII option and enter the entity names as comma-separated values&mdash;for example, **incident,account,contact**&mdash;as described in the following section.

#### Add the BlockChromeProcessPooling UII option

To skip inline navigation for certain entities, you must configure the option on the **Active UII Options** page and enter the entity names as comma-separated values.

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **BlockChromeProcessPooling**.

8. In the **Value** field, enter the entity names as comma-separated values&mdash;for example, **incident,account,contact**.

9. Select **Save**.

### Hide command bar in Chrome process

In Chrome process, the command bar is always shown on pooled Chrome process instances. You can hide the command bar for a specific entity or for all entities in the Chrome process pooled instances.

**To hide command bar for a specific entity**

[Add the BlockChromeProcessPooling UII option](#add-the-blockchromeprocesspooling-uii-option), as described earlier in this article.

**To hide command bar for all entities**

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **HideCommandBar**.

8. In the **Value** field, select **True**.

9. Select **Save**.

### Show nav bar in Chrome process

In Chrome process, the nav bar is always hidden on the pooled Chrome process instances. You can show the nav bar for a specific entity or for all entities in the Chrome process pooled instances.

**To show nav bar for a specific entity**

[Add the BlockChromeProcessPooling UII option](#add-the-blockchromeprocesspooling-uii-option), as described earlier in this article.

**To show nav bar for all entities**

Use the **ShowNavBar** UII option if you want to show the nav bar for all the entities in the Chrome process pooled instances.

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **ShowNavBar**.

8. In the **Value** field, select **True**.

9. Select **Save**.

### Block second navigation in Chrome process pooling

When an application (hosted control) is initialized and you perform an inline navigation to another entity page by using the same application (hosted control), then the second navigation also occurs inline. If you have a specific window navigation rule between two instances of the same entity type (such as a **Route Window** action and an **In Place** type), then the window navigation rule loops in a recursive manner, causing Unified Service Desk to crash.

For example, with Chrome process pooling, if you've set a window navigation rule to navigate from an account tab to another account tab, with the **Route Window** action and **In Place** type, the window navigation rule loops in a recursive manner, causing Unified Service Desk to crash.

To avoid the crash of Unified Service Desk, you can do one of the following:

- Remove or change the window navigation rule
- Add the **BlockChromeProcessSecondInlineNavigation** UII option

**To remove or change the window navigation rule**

**Window navigation rule for same entity navigation**: You can remove or delete the window navigation rule itself because with Chrome process instance pooling, every entity page navigation happens inline after the first entity page navigation.

**Window navigation rule for different entity navigation**: You can change the window navigation rule to be more specific about which entity you want the navigation to originate from. For example, you can set the window navigation rule from a Contact or a Case entity to the Account entity type, by using the **Route Window** action and **In Place** type.

<a name="add-chrome-uii-option"></a>

#### Add the BlockChromeProcessSecondInlineNavigation UII option

By default, second inline navigation is blocked when using Chrome process&mdash;that is, the option is enabled by default. However, if you want to allow the second inline navigation&mdash;in other words, disable the option&mdash;create the **BlockChromeProcessSecondInlineNavigation** UII option and set the value as **False**.

After adding the UII option, if you set the value as **True**, the option is enabled and blocks the second inline navigation.

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **BlockChromeProcessSecondInlineNavigation**.

8. In the **Value** field, select **True**.

9. Select **Save**.

::: moniker-end

## Pool process instances for IE process

> [!NOTE]
>
> Because support for Internet Explorer 11 is deprecated, support for IE process has also been discontinued in Unified Service Desk. More information: [Deprecation announcement](../../customer-service/implement/deprecations-customer-service.md#internet-explorer-11-support-for-dynamics-365-and-microsoft-power-platform-is-deprecated)
[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Internet Explorer instances for hosted controls to use. Opening a hosted control by using a pooled Internet Explorer instance enhances the performance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

> [!NOTE]
> - The Internet Explorer pooling feature supports only CRM entity pages hosted in the CRM Page hosted control.
> - When you enable the pooling feature and open a CRM Page hosted control, you can see in Task Manager that [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] creates a number of Internet Explorer Process instances for hosted controls to use. 
> - The performance of the Internet Explorer pooling feature is dependent on the resources available on the client computer.
### Enable pooling for IE process

By default, Internet Explorer pooling is disabled. To enable pooling, you must configure the option on the **Active UII Options** page and set it to **True**.

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**. 

4. In the site map, under **Advanced Settings**, select **Options**.

5. On the **Active UII Options** page, select **New**.

6. In the **Global Option** field, select **Others**.

7. In the **Name** field, enter **InternetExplorerPooling**.

8. In the **Value** field, select **True**.

9. Select **Save**.

   ![Enable InternetExplorerPooling option.](../../unified-service-desk/unified-interface/media/crm-itpro-usd-options-internetexplorerpooling.PNG "Enable InternetExplorerPooling option")

### See also

- [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
