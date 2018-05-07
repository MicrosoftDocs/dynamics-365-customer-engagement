---
title: "Redirect to a new URL on a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to create a redirect URL to redirect a user to another page in a site."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: a5eddd85-8078-4f9c-b843-987a87841e84
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Add a redirect URL to a new URL on a portal

Customers frequently want to have a simple URL that redirects to a page deeper in the site, or they want to allow for a legacy URL to be used with the site and automatically redirect to a new URL in the site. Page redirects allow a content author to specify a URL that, when requested, will be redirected on a permanent or temporary basis to a specific webpage or web file. These redirect URLs are managed separately from the page content so that they do not have to fit directly in the web hierarchy.

## Create a redirect
1. Navigate to the **Portals** area and, under the **Website** section, select **Redirects**, and then select **New** on the toolbar.

    ![Active redirects](media/active-redirects.png "Active redirects")  

2. Enter the redirect information as described below.

| Name        | Description                                                                                                                                  |
|-------------|----------------------------------------------------------------------------------------------------------------------------------------------|
| Name        | The friendly name of the redirect. (Can be anything. Make it easy to identify.)                                                              |
| Website     | The website the redirect is associated with. (The site the user is redirected from.)                                                         |
| Inbound URL | The partial URL that is to be redirected. (The page the user is redirected from.)                                                            |
| Status Code | One of the following:  **302 (Temporary Redirect)**: returns a temporary redirect status. This is the default.                                               -   **301 (Permanent Redirect)**: returns a permanent redirect status, indicating the resource has moved permanently.                          |
| URL         | A target external URL to be redirected to. (Use this if the user is being redirected to a link external to the website specified above.)                            |
| Web Page    | A target internal webpage to be redirected to. (Use this if the user is being redirected to a page internal to the website specified above.) |
| Site Marker | A target internal site marker to be redirected to.                                                                                           |

3. After entering the required fields and specifying a value for at least one of the URL, Web Page, or Site Marker fields, select **Save**.

    ![Redirect a customer survey](media/redirect-customer-survey.png "Redirect a customer survey")  

## Use the redirect

When the inbound URL is requested, the browser is redirected to the URL of the target webpage for the matching redirects entry.

For example, for an Inbound URL value of cs-survey with a target webpage set to the Customer Support Survey page, the following request:

http://customerportal.contoso.com/cs-survey

results in the browser requesting the following URL:

http://customerportal.contoso.com/surveys/customer-service-survey/

### See also
[Configure a Dynamics 365 portal](configure-portal.md)  
[Add a webpage to render a list of records](add-webpage-render-list-records.md)  
[Create and run advertisements on a portal](create-run-advertisement.md)  
[Gather feedback by using polls on a portal](gather-feedback-poll.md)  
[Rate or vote on a webpage or blog post on a portal](rate-webpage-blog-post.md)
