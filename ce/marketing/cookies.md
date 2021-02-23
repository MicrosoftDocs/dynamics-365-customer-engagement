---
title: "Cookies set and read (Dynamics 365 Marketing) | Microsoft Docs"
description: "Describes how cookies are set and used in Dynamics 365 Marketing."
ms.date: 09/10/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# How Dynamics 365 Marketing uses cookies

Dynamics 365 Marketing identifies website visitors by using a technology called *cookies*. A cookie is a small file that's sent by a server and saved by your browser. Each time you visit a server for which a cookie is set, your browser submits that cookie value back to the server. In this way the cookie can provide a unique visitor ID, which enables the server to return information that is unique to you. This is the technology that originally made the online shopping cart possible.

> [!IMPORTANT]
> Many countries/regions (including the European Union) require that you obtain consent before setting a cookie on a resident's machine. It is your organization's responsibility to be aware of, and conform to, all relevant laws and regulations in the markets where you operate, including when it comes to obtaining consent to set cookies. For example, you can read more about the EU regulations at [ec.europa.eu/ipg/basics/legal/cookies/](https://ec.europa.eu/ipg/basics/legal/cookies/).

Dynamics 365 Marketing can generate a small piece of JavaScript code that reads and sets cookies on any page where you place the code. All you need to do to let Dynamics 365 Marketing record visits to a given page is to include the script on that page.

A cookie identifies a single device/browser/account combination. If you use two different browsers (such as Mozilla Firefox and Internet Explorer on the same computer, each will have its own cookie. Likewise, you'll have different cookies on each device that you use, and another user with their own account on your computer will have yet other cookies. If a device gets deleted and reinstalled, all cookies will also be deleted. Nevertheless, Dynamics 365 Marketing attempts to resolve the actual marketing contact associated with each unique cookie ID.

Whenever a contact submits a marketing page, Dynamics 365 Marketing correlates the behavior-analysis cookie ID with the incoming contact data submitted with the marketing-page form. In this way the cookie ID becomes mapped to a Dynamics 365 Marketing contact ID, so now we can determine who has been browsing the site. The system applies its configured duplicated-detection method to determine whether incoming landing-page data should be mapped to an existing contact or to a new contact.

Dynamics 365 Marketing sets three different types of cookies:

- **Long-term behavioral-analysis cookie**: This cookie is set and/or read on any webpage where you have placed a Dynamics 365 Marketing website behavioral-analysis script. It enables Dynamics 365 Marketing to score leads based on their level of interaction with a given website. The cookie contains no personal information, but does uniquely identify a specific browser on a specific machine, and Dynamics 365 Marketing can use it to correlate this ID with an actual contact in the Dynamics 365 Marketing database. The cookie remains active for two years.
- **Short-term, single-visit cookie**: This cookie is also set and/or read on any webpage where you have placed a Dynamics 365 Marketing website behavioral-analysis script. By default, it expires after just 30 minutes. Dynamics 365 Marketing uses it to group all page loads by a given visitor that are recorded by the same behavioral-analysis script and that occur within the configured timeframe. It will consider all of these as part of a single &quot;visit&quot; to the website.
- **Event website**: The event website uses a session cookie to enable contacts to sign in and register for events. Additionally, it uses cookies to store the user's language.

> [!NOTE]
> The Dynamics 365 Marketing application itself also sets cookies to enable sign-in sessions and other technical features. These only affect direct users of Dynamics 365 Marketing (such as your internal marketing personnel), not the general public. Microsoft&#39;s standard privacy policy applies for these users.

### See also

[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[Register link clicks and website visits](register-engagement.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]