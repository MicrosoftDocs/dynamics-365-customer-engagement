---
title: "Deploy Pages with Real-time Marketing Forms"
description: "Learn how Real-time Marketing Forms can be deployed on Power Pages and other destinations"
ms.date: 06/21/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: petkra
ms.author: petkra
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Deploy Pages with Real-time Marketing Forms

To capture the interests of customers, Marketing forms are the tool of choice. Dynamics 365 Marketing recently added this capability natively to the Real-time engine of the product (RTM forms). While the form creation and designer experience has been aligned to the general concept of Real-time Marketing, we also now have more capabilities to publish those forms. In this article, we want to explore those possibilities in depth. 

# Hosting options

After the form is created and designed, it must be published so that customers can access and complete it. Typically, forms are included on CMS systems where, in the context of a product or service, they allow the customer to request further information or to be regularly informed.
Currently we have the following options to publish a form:

> [!div class="mx-imgBorder"]
> ![Publish real-time forms.](media/real-time-marketing-forms-publishing1.png "Publish real-time forms")

Although this looks like only two options, the JavaScript code option could be used in different ways and helps to publish the form basically anywhere. To publish a form in your own CMS however, it is required to authenticate the domains with Dynamics 365 Marketing. To authenticate domains, please follow the documentation.
It is worth mentioning that those options are not exclusive to a given location, which means we can publish the same form in multiple locations. Let’s take a closer look at the options. 

> [!IMPORTANT]
> The ability to capture the content of forms not created with Dynamics 365 Marketing does not currently exist.

## Use a standalone page

There are situations where there is no other publishing option available or not wanted, for example if a very high volume of access is expected. In those cases, a form can be published in a standalone page which is hosted in the content delivery network (CDN) of Microsoft. This guarantees a very short loading time and high availability for the form. Pushing the “Create” button on the left side of the dialog in the screenshot above will create such a page and make the form available right away. 

> [!div class="mx-imgBorder"]
> ![Publish options for real-time forms.](media/real-time-marketing-forms-publishing-options.png "Publish options for real-time forms")

Today, the domain provided for the standalone page is provided by Dynamics Marketing. Coming soon, customers will be able to add their own domain for use with these standalone pages.
One thing to notice here is that there is a caching mechanism in the background to deliver the page as fast as possible. But this also means that if the form is changed, those changes are not reflected immediately on the page. It could take up to 10 minutes for the cache to be updated. This effect is always present, no matter which method is used to include the form.

> [!NOTE]
> There is a URL parameter which can be appended to given URL to get around the cached version and force the infrastructure to load the updated version of the form. Just append “#d365mkt-nocache” to the URL and the page ignores the cache and loads the form from Dynamics Marketing. 

## Single page application (SPA)

The new form experience is designed to use a JavaScript API to use various events to change the behaviour of the form. This design also allows the form to be included and rendered via this API, as well as used within a single-page application with React (SPA). The process is described the the developer documentation under [Extend real-time marketing forms using code (Dynamics 365 Marketing Developer Guide) | Microsoft Learn](real-time-marketing-business-units.md#enabling-business-unit-scopes-in-real-time-marketing). The following screenshot shows an embedded Marketing form on a React page. 

> [!div class="mx-imgBorder"]
> ![RTM Form on SPA.](media/real-time-marketing-forms-spa.png "RTM Form on SPA")

The only thing to take care of is to replace the identifier of the form (msdynmkt_marketingformid) and the organization (organizationid) as well as the endpoint for that organization. This information is provided in the code snippet that is generated after from publishing. 

## Power Pages

RTM forms can also be hosted on Power Pages (formerly known as Power Apps Portals). There is no need to connect the corresponding website to Marketing. The process here is as follows: 

1. Create a new page or duplicate / edit an existing one in Power Pages Studio 

> [!div class="mx-imgBorder"]
> ![RTM Form on Pages 1.](media/real-time-marketing-forms-pages1.png "RTM Form on Pages 1")

2. Use the option to edit the page in Visual Studio Code 

> [!div class="mx-imgBorder"]
> ![RTM Form on Pages 2.](media/real-time-marketing-forms-pages2.png "RTM Form on Pages 2")

3. Insert the code snippetd generated by the form where you want the form to show up, close the editor and sync the changes back to the portal. 

> [!div class="mx-imgBorder"]
> ![RTM Form on Pages 3.](media/real-time-marketing-forms-pages3.png "RTM Form on Pages 3")

4. Sync the changes back to the portal 

> [!div class="mx-imgBorder"]
> ![RTM Form on Pages 4.](media/real-time-marketing-forms-pages4.png "RTM Form on Pages 4")

5. Start the preview of the page

> [!div class="mx-imgBorder"]
> ![RTM Form on Pages 5.](media/real-time-marketing-forms-pages5.png "RTM Form on Pages 5")

One caveat here is that the form won’t show up in the design mode in the Power Pages Studio. But if we choose to preview the page in the browser, the form shows up and can be used. It is planned to improve this authoring experience in the future so you would be able to add the marketing form using UI of Power Pages Studio.

# Summary

The new real-time Form designer offers a very pleasant and easy way to create forms for the real-time Marketing module. The publishing options and better scripting possibilities offer a lot of flexibility to provide forms on web pages for customers. As a general guidance, we can state the following: 
- There is no need to connect Dynamics Marketing with Power Portals / Power Pages
- A very easy and effective way to build a single landing page, is just to publish the form as a standalone page
- If you need complex marketing web site with multiple pages, you can leverage Power Pages Studio. It is possible to embed the RTM Marketing Form to web site built in Power Pages like described above.


At the time of writing, there is already a preview of further functionalities, namely the use of this designer also for event registrations. Here, too, customer feedback has already been considered in the form that in interaction with content-dependent display of a form, for example, the same form can always be used for many similar events in the future.
