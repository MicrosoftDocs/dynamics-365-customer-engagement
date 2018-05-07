---
title: "Cookies set and read (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Describes how cookies are set and used in Dynamics 365 for Marketing"
keywords: "cookies; privacy"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a7136797-5995-425f-a49e-f037e53b7fa7
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
ms.custom: dyn365-marketing
---

# How [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses cookies

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] identifies website visitors by using a technology called _cookies_. A cookie is a small file that's sent by a server and saved by your browser. Each time you visit a server for which a cookie is set, your browser submits that cookie value back to the server. In this way the cookie can provide a unique visitor ID, which enables the server to return information that is unique to you. This is the technology that originally made the online shopping cart possible.

> [!IMPORTANT]
> Many countries/regions (including the European Union) require that you obtain consent before setting a cookie on a resident's machine. It is your organization's responsibility to be aware of, and conform to, all relevant laws and regulations in the markets where you operate, including when it comes to obtaining consent to set cookies. For example, you can read more about the EU regulations at [ec.europa.eu/ipg/basics/legal/cookies/](http://ec.europa.eu/ipg/basics/legal/cookies/).

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can generate a small piece of JavaScript code that reads and sets cookies on any page where you place the code. All you need to do to let [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] record visits to a given page is to include the script on that page.

A cookie identifies a single device/browser/account combination. If you use two different browsers (such as [!include[](../includes/tn-firefox.md)] and [!include[](../includes/pn-internet-explorer.md)]) on the same computer, each will have its own cookie. Likewise, you'll have different cookies on each device that you use, and another user with their own account on your computer will have yet other cookies. If a device gets deleted and reinstalled, all cookies will also be deleted. Nevertheless, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] attempts to resolve the actual marketing contact associated with each unique cookie ID.

Whenever a contact submits a marketing page, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] correlates the behavior-analysis cookie ID with the incoming contact data submitted with the marketing-page form. In this way the cookie ID becomes mapped to a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] contact ID, so now we can determine who has been browsing the site. The system applies its configured duplicated-detection method to determine whether incoming landing-page data should be mapped to an existing contact or to a new contact.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] sets three different types of cookies:

- **Long-term behavioral-analysis cookie**: This cookie is set and/or read on any webpage where you have placed a [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] website behavioral-analysis script. It enables [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to score leads based on their level of interaction with a given website. The cookie contains no personal information, but does uniquely identify a specific browser on a specific machine, and [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can use it to correlate this ID with an actual contact in the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] database. The cookie remains active for two years.
- **Short-term, single-visit cookie**: This cookie is also set and/or read on any webpage where you have placed a [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] website behavioral-analysis script. By default, it expires after just 30 minutes (although you can configure this). [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses it to group all page loads by a given visitor that are recorded by the same behavioral-analysis script and that occur within the configured timeframe; it will consider all of these as part of a single &quot;visit&quot; to the website.
- **Marketing page registration cookie**: This cookie is set when a contact submits a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] marketing page where the **Remember my information** check box has been selected. It enables the marketing page to show a prefilled form the next time the same contact uses it. The information stored in the cookie is a cryptographic, unique identifier and doesn't contain the data submitted or any means for an external application to uncover the submitted information.
- **Event portal**: The event portal uses a session cookie to enable contacts to sign in and register for events.

> [!NOTE]
> The [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] application itself also sets cookies to enable sign-in sessions and other technical features. These only affect direct users of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] (such as your internal marketing personnel), not the general public. Microsoft&#39;s standard privacy policy applies for these users.

### See also

[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[Register contacts' engagement](register-engagement.md)
