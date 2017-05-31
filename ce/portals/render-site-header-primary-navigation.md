---
title: "Render a website header and primary navigation bar in a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: d6af4c8f-9164-4b18-9e1d-644293063fd9
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Render a website header and primary navigation bar



Render a website header and primary navigation bar, using portals settings, snippets, weblinks, and sitemarkers. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Store source content by using web templates](store-content-web-templates.md)  

>[!Note]
>The example in this topic will only function correctly if cross-request header caching is disabled for your application. It is enabled by default in version 7.0.0019 and later. It can be disabled by creating a Site Setting named Header/OutputCache/Enabled, and setting its value to false.


```
&lt;divclass="masthead hidden-xs"&gt;&lt;divclass="container"&gt;&lt;divclass="toolbar"&gt;&lt;divclass="toolbar-row"&gt;{%assignsearch\_enabled=settings\['search/enabled'\]|boolean|default:true%}{%assignsearch\_page=sitemarkers\['Search'\]%}{%ifsearch\_enabledandsearch\_page%}&lt;divclass="toolbar-item toolbar-search"&gt;&lt;formmethod="GET"action="{{search\_page.url}}"role="search"&gt;&lt;labelfor="q"class="sr-only"&gt;{{snippets\["Header/Search/Label"\]|default:"Search"}}&lt;/label&gt;&lt;divclass="input-group"&gt;&lt;inputtype="text"class="form-control"id="q"name="q"placeholder="{{snippets\["Header/Search/Label"\]|default:"Search"}}"value="{{params.q}}"title="{{snippets\["Header/Search/Label"\]|default:"Search"}}"&gt;&lt;divclass="input-group-btn"&gt;&lt;buttontype="submit"class="btn

btn-default"title="{{snippets\["Header/Search/ToolTip"\]|default:"Search"}}"&gt;&lt;spanclass="fa fa-search"aria-hidden="true"&gt;&lt;/span&gt;&lt;/button&gt;&lt;/div&gt;&lt;/div&gt;&lt;/form&gt;&lt;/div&gt;{%endif%}&lt;divclass="toolbar-item"&gt;&lt;divclass="btn-toolbar"role="toolbar"&gt;{%ifuser%}&lt;divclass="btn-group"&gt;&lt;ahref="\#"class="btn

btn-default dropdown-toggle"data-toggle="dropdown"&gt;&lt;spanclass="fa fa-user"aria-hidden="true"&gt;&lt;/span&gt;&lt;spanclass="username"&gt;{{user.fullname}}&lt;/span&gt;&lt;spanclass="caret"&gt;&lt;/span&gt;&lt;/a&gt;&lt;ulclass="dropdown-menu pull-right"role="menu"&gt;{%assignshow\_profile\_nav=settings\["Header/ShowAllProfileNavigationLinks"\]|boolean|default:true%}{%ifshow\_profile\_nav%}{%assignprofile\_nav=weblinks\["Profile

Navigation"\]%}{%ifprofile\_nav%}{%forlinkinprofile\_nav.weblinks%}&lt;li&gt;&lt;ahref="{{link.url}}"&gt;{{link.name}}&lt;/a&gt;&lt;/li&gt;{%endfor%}{%endif%}{%else%}&lt;li&gt;&lt;ahref="{{sitemarkers\['Profile'\].url}}"&gt;{{snippets\["Profile Link Text"\]|default:"Profile"}}&lt;/a&gt;&lt;/li&gt;{%endif%}&lt;liclass="divider"&gt;&lt;/li&gt;&lt;li&gt;&lt;ahref="/account-signout?returnUrl={{request.raw\_url}}"&gt;{{snippets\["links/logout"\]|default:"SignOut"}}&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;{%else%}&lt;divclass="btn-group"&gt;&lt;aclass="btn btn-primary"href="{{sitemarkers\['Login'\].url|add\_query:'returnurl',request.path\_and\_query}}"&gt;&lt;spanclass="fa fa-sign-in"aria-hidden="true"&gt;&lt;/span&gt;{{snippets\["links/login"\]|default:"Sign

In"}}&lt;/a&gt;&lt;/div&gt;{%endif%}&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;{%editablesnippets'Header'type:'html'%}&lt;/div&gt;&lt;/div&gt;&lt;divclass="header-navbar navbar navbar-default navbar-static-top"role="navigation"&gt;&lt;divclass="container"&gt;&lt;divclass="navbar-header"&gt;&lt;buttontype="button"class="navbar-toggle"data-toggle="collapse"data-target="\#header-navbar-collapse"&gt;&lt;spanclass="sr-only"&gt;Toggle

navigation&lt;/span&gt;&lt;spanclass="icon-bar"&gt;&lt;/span&gt;&lt;spanclass="icon-bar"&gt;&lt;/span&gt;&lt;spanclass="icon-bar"&gt;&lt;/span&gt;&lt;/button&gt;&lt;divclass="navbar-left visible-xs"&gt;{%editablesnippets'Mobile Header'type:'html'%}&lt;/div&gt;&lt;/div&gt;&lt;divid="header-navbar-collapse"class="navbar-collapse

collapse"&gt;&lt;divclass="navbar-left hidden-xs"&gt;{%editablesnippets'Navbar Left'type:'html'%}&lt;/div&gt;{%assignprimary\_nav=weblinks\["Primary Navigation"\]%}{%ifprimary\_nav%}&lt;divclass="navbar-left {%ifprimary\_nav.editable%}xrm-entity xrm-editable-adx\_weblinkset{%endif%}"data-weblinks-maxdepth="2"&gt;&lt;ulclass="nav

navbar-nav weblinks"&gt;{%forlinkinprimary\_nav.weblinks%}{%iflink.display\_page\_child\_links%}{%assignsublinks=sitemap\[link.url\].children%}{%else%}{%assignsublinks=link.weblinks%}{%endif%}&lt;liclass="weblink {%ifsublinks.size&gt;0%} dropdown{%endif%}"&gt;&lt;a{%ifsublinks.size&gt;0%}href="\#"class="dropdown-toggle"data-toggle="dropdown"{%else%}href="{{link.url}}"{%endif%}{%iflink.nofollow%}rel="nofollow"{%endif%}{%iflink.tooltip%}title="{{link.tooltip}}"{%endif%}&gt;{%iflink.image%}{%iflink.image.urlstartswith'.'%}&lt;spanclass="{{link.image.url|split:'.'|join}}"aria-hidden="true"&gt;&lt;/span&gt;{%else%}&lt;imgsrc="{{link.image.url}}"alt="{{link.image.alternate\_text|default:link.tooltip}}"{%iflink.image.width%}width="{{link.image.width}}"{%endif%}{%iflink.image.height%}height="{{link.image.height}}"{%endif%}/&gt;{%endif%}{%endif%}{%unlesslink.display\_image\_only%}{{link.name}}{%endunless%}{%ifsublinks.size&gt;0%}&lt;spanclass="caret"&gt;&lt;/span&gt;{%endif%}&lt;/a&gt;{%ifsublinks.size&gt;0%}&lt;ulclass="dropdown-menu"role="menu"&gt;{%iflink.url%}&lt;li&gt;&lt;ahref="{{link.url}}"{%iflink.nofollow%}rel="nofollow"{%endif%}{%iflink.tooltip%}title="{{link.tooltip}}"{%endif%}&gt;{{link.name}}&lt;/a&gt;&lt;/li&gt;&lt;liclass="divider"&gt;&lt;/li&gt;{%endif%}{%forsublinkinsublinks%}&lt;li&gt;&lt;ahref="{{sublink.url}}"{%ifsublink.nofollow%}rel="nofollow"{%endif%}{%ifsublink.tooltip%}title="{{link.tooltip}}"{%endif%}&gt;{{sublink.name|default:sublink.title}}&lt;/a&gt;&lt;/li&gt;{%endfor%}&lt;/ul&gt;{%endif%}&lt;/li&gt;{%endfor%}&lt;/ul&gt;{%editableprimary\_nav%}&lt;/div&gt;{%endif%}&lt;divclass="navbar-right hidden-xs"&gt;{%editablesnippets'Navbar Right'type:'html'%}&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;
```

### See Also

[Create advanced templates for portals](create-advanced-templates.md)  
[Create a custom page template by using Liquid and a web template page template](create-custom-template.md)  
[Create a custom page template to render an RSS feed](render-rss-custom-page-template.md)  
[Render the entity list associated with the current page](render-entity-list-current-page.md)  
[Render up to three levels of page hierarchy by using hybrid navigation](hybrid-navigation-render-page-hierachy.md)  

