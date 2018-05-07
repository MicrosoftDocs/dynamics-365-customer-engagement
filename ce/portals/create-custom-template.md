---
title: "Create a custom page template by using Liquid and a web template page template for a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to create a custom page template by using Liquid operators."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 59342ba3-6848-44bf-ab29-a35687039f02
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Create a custom page template by using Liquid and a Web Template page template

[comment]: <> (Need more elaborate description of the steps)
In this example, we'll create a custom page template by using Liquid and a Web Template page template. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Store source content by using web templates](store-content-web-templates.md).  
Our goal is to build a simple two-column template that uses a web link set as left-side navigation, with the page content to the right. Something like this:

![Custom page template](media/custom-page-template.png "Custom page template")  

## Step 1: Create Web Template and write the Liquid template code

First, we'll create our Web Template and write the Liquid template code. We're likely to reuse some common elements of this template in future templates. So, we'll create a common base template that we'll then extend with our specific template. Our base template will provide breadcrumb links and our page title/header, as well as define our one-column layout:

![Web template one column layout](media/web-template-one-column-layout.png "Web template one column layout")  
> [!TIP]
> Read about template inheritance using the block and extends tags: [Template tags](#template-tags)

## Step 2: Create a new Web Template that extends our base layout template

Use the navigation web link set associated with the current page for our navigation links to create a new Web Template that extends our base layout template.

![Web template web links left navigation layout](media/web-template-weblinks-left-navigation-layout.png "Web template web links left navigation layout")  

> [!TIP]
> Familiarize yourself on how to load web link sets using the [weblinks](#weblinks) object.

## Step 3: Create a new Web Template page template that uses the Web Template

![Page template weblinks left navigation layout](media/page-template-weblinks-left-navigation-layout.png "Page template weblinks left navigation layout")  

Now, all that's left to do is create a Web Page that uses our page template, and has an associated Web Link Set, and we have our result.

![Web page with left navigation](media/web-page-left-navigation.png "Web page with left navigation")  

### See also

[Create advanced templates for portals](create-advanced-templates.md)  
[Create a custom page template to render an RSS feed](render-rss-custom-page-template.md)  
[Render the entity list associated with the current page](render-entity-list-current-page.md)  
[Render a website header and primary navigation bar](render-site-header-primary-navigation.md)  
[Render up to three levels of page hierarchy by using hybrid navigation](hybrid-navigation-render-page-hierachy.md)  

