---
title: "Render an RSS feed using custom page template for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 24413b7a-1fcc-4146-a8c9-899ef9cdcceb
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Create a custom page template to render an RSS feed

Applies To: Dynamics 365 (online), Dynamics CRM Online

In this example, we'll create a custom page template to render an [*RSS feed*](http://en.wikipedia.org/wiki/RSS) of news articles, using Liquid and a Web Template Page Template. More information: [*Store source content by using web templates*](store-content-web-templates.md)  

First, we'll create a new Dynamics 365 view that we'll use to load the data for our feed. In this example, we'll make it a view on Web Pages, and use this entity to store our articles. We can use this view to configure the sorting and filtering of results, and include as columns the entity attributes that we want available in our Liquid template.

![Edit a page template](media/edit-page-template.png "Edit a page template")  

Next, we'll create a Web Template for our RSS feed. This template will be applied to a particular webpage in our website, so we'll use the title and summary of that page as the title and description of the feed. The we'll use the entityview tag to load our newly-created "News Articles" view. More information: [*Dynamics 365 entity tags*](#dynamics-365-entity-tags). Note that we also set the **MIME Type** field of the Web Template to application/rss+xml. This indicates what the response content type could be when our template is rendered.  

![Configure a web template for an RSS feed](media/web-template-rss-feed.png "Configure a web template for an RSS feed")  

Now, we'll create a new page template, allowing us to assign our RSS feed template to any webpage in our website. Note that we deselect **Use Website Header and Footer**, as we want to take over rendering of the entire page response for our feed.

![Configure a page template for an RSS feed](media/page-template-rss-feed.png "Configure a page template for an RSS feed")  

Now all that's left is to create a new Web Page to host our feed, giving it a title and summary, and assigning it our "RSS Feed" template. We can do this in Dynamics 365 or by using the portal inline editing features:

![Add a new child page](media/add-new-child-page.png "Add a new child page")  

Now, when we request this new webpage, we'll receive our RSS feed XML:

![Example of an RSS feed](media/rss-feed-example.png "Example of an RSS feed")  

In this example, we've seen how we can combine Liquid, Web Templates, Dynamics 365 views, and portals content management features to create a custom RSS feed. The combination of these features adds powerful customization capabilities to any portal application.

### See Also

[*Create advanced templates for portals*](create-advanced-templates.md)  
[*Create a custom page template by using Liquid and a web template page template*](create-custom-template.md)  
[*Render the entity list associated with the current page*](render-entity-list-current-page.md)  
[*Render a website header and primary navigation bar*](render-site-header-primary-navigation.md)  
[*Render up to three levels of page hierarchy by using hybrid navigation*](hybrid-navigation-render-page-hierachy.md)  

