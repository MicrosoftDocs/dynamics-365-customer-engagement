---
title: "Create a custom page template by using Liquid and a web template page template for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 59342ba3-6848-44bf-ab29-a35687039f02
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Create a custom page template by using Liquid and a web template page template



In this example, we'll create a custom page template by using Liquid and a Web Template page template. More information: [*Store source content by using web templates*](store-content-web-templates.md)  

Our goal is to build a simple two-column template that uses a web link set as left-side navigation, with the page content to the right. Something like this:

![Custom page template](media/custom-page-template.png "Custom page template")  

First, we'll create our Web Template and write the Liquid template code. But, thinking ahead, we realize we're likely to reuse some common elements of this template in future templates. So, we'll create a common base template that we'll then extend with our specific template. Our base template will provide breadcrumb links and our page title/header, as well as define our one-column layout:

![Web template one column layout](media/web-template-one-column-layout.png "Web template one column layout")  

|  **Note **                                     |  
|-----------------------------------------------------------------------------------------------------|
| Read about template inheritance using the block and extends tags: [*Template tags*](#template-tags) |  

Then, we'll create a new Web Template that extends our base layout template, using the navigation web link set associated with the current page for our navigation links:

![Web template web links left navigation layout](media/web-template-weblinks-left-navigation-layout.png "Web template web links left navigation layout")  

|  **Note **                     |  
|-------------------------------------------------------------------------------------|
| Read about loading web link sets using the weblinks object: [*weblinks*](#weblinks) |  

Next, we create a new Web Template page template that uses our Web Template:

![Page template weblinks left navigation layout](media/page-template-weblinks-left-navigation-layout.png "Page template weblinks left navigation layout")  

Now, all that's left to do is create a Web Page that uses our page template, and has an associated Web Link Set, and we have our result.

![Web page with left navigation](media/web-page-left-navigation.png "Web page with left navigation")  

### See Also

[*Create advanced templates for portals*](create-advanced-templates.md)  
[*Create a custom page template to render an RSS feed*](render-rss-custom-page-template.md)  
[*Render the entity list associated with the current page*](render-entity-list-current-page.md)  
[*Render a website header and primary navigation bar*](render-site-header-primary-navigation.md)  
[*Render up to three levels of page hierarchy by using hybrid navigation*](hybrid-navigation-render-page-hierachy.md)  

