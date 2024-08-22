---
title: "SLA table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# SLA table/entity reference

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service SLA table extends the [Microsoft Dynamics 365 SLA table](/dynamics365/developer/entities/sla).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode)

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|1083|**Opportunity Line**|
|1085|**Quote Line**|
|1089|**Order Line**|
|9820|**Secured Masking Column**|
|10035|**Shared Workspace Non-Relational**|
|10058|**CascadeGrantRevokeAccessRecordsTracker**|
|10059|**CascadeGrantRevokeAccessVersionTracker**|
|10060|**RevokeInheritedAccessRecordsTracker**|
|10061|**TdsMetadata**|
|10062|**Model-Driven App Element**|
|10063|**Model-Driven App Component Node's Edge**|
|10064|**Model-Driven App Component Node**|
|10065|**Model-Driven App Setting**|
|10066|**Model-Driven App User Setting**|
|10067|**Organization Setting**|
|10068|**Setting Definition**|
|10069|**CanvasApp Extended Metadata**|
|10070|**Service Plan Mapping**|
|10076|**OData v4 Data Source**|
|10077|**Workflow Binary**|
|10078|**Credential**|
|10079|**Desktop Flow Module**|
|10080|**Flow Capacity Assignment**|
|10081|**Flow Credential Application**|
|10082|**Flow Event**|
|10083|**Flow Machine**|
|10084|**Flow Machine Group**|
|10085|**Flow Machine Image**|
|10086|**Flow Machine Image Version**|
|10087|**Flow Machine Network**|
|10088|**ProcessStageParameter**|
|10089|**Work Queue**|
|10090|**Work Queue Item**|
|10091|**Desktop Flow Binary**|
|10092|**Flow Log**|
|10093|**Flow Run**|
|10094|**Action Approval Model**|
|10095|**Approval**|
|10096|**Approval Request**|
|10097|**Approval Response**|
|10098|**Approval Step**|
|10099|**Await All Action Approval Model**|
|10100|**Await All Approval Model**|
|10101|**Basic Approval Model Data**|
|10102|**Flow Approval**|
|10118|**AICopilot**|
|10119|**AIPluginAuth**|
|10120|**AI Plugin Conversation Starter**|
|10121|**AI Plugin Conversation Starter Mapping**|
|10122|**AI Plugin Governance**|
|10123|**AI Plugin Governance Extended**|
|10124|**AIPluginOperationResponseTemplate**|
|10125|**AIPluginTitle**|
|10126|**SideloadedAIPlugin**|
|10127|**AIPlugin**|
|10128|**AIPluginExternalSchema**|
|10129|**AIPluginExternalSchemaProperty**|
|10130|**AIPluginInstance**|
|10131|**AIPluginOperation**|
|10132|**AIPluginOperationParameter**|
|10133|**AIPluginUserSetting**|
|10135|**AI Event**|
|10136|**AI Builder Feedback Loop**|
|10137|**AI Form Processing Document**|
|10138|**AI Object Detection Image**|
|10139|**AI Object Detection Label**|
|10141|**AI Object Detection Image Mapping**|
|10143|**AI Builder Dataset**|
|10144|**AI Builder Dataset File**|
|10145|**AI Builder Dataset Record**|
|10146|**AI Builder Datasets Container**|
|10147|**AI Builder File**|
|10148|**AI Builder File Attached Data**|
|10149|**Help Page**|
|10150|**Tour**|
|10151|**BotContent**|
|10152|**ConversationTranscript**|
|10153|**Copilot**|
|10154|**Copilot component**|
|10155|**Copilot component collection**|
|10166|**Comment**|
|10167|**Fabric AISkill**|
|10168|**App Insights Metadata**|
|10169|**Dataflow Connection Reference**|
|10170|**Schedule**|
|10171|**Dataflow Template**|
|10172|**Dataflow DatalakeFolder**|
|10173|**Data Movement Service Request**|
|10174|**Data Movement Service Request Status**|
|10175|**DMS Sync Request**|
|10176|**DMS Sync Status**|
|10177|**Knowledge Asset Configuration**|
|10178|**Module Run Detail**|
|10179|**Salesforce Structured Object**|
|10180|**Salesforce Structured QnA Config**|
|10181|**Workflow Action Status**|
|10182|**PDF Setting**|
|10183|**Activity File Attachment**|
|10184|**Teams chat**|
|10185|**Service Configuration**|
|10186|**SLA KPI**|
|10187|**Integrated search provider**|
|10188|**Knowledge Management Setting**|
|10189|**Knowledge Federated Article**|
|10190|**Knowledge Federated Article Incident**|
|10191|**Search provider**|
|10192|**Knowledge Article Image**|
|10193|**Knowledge Configuration**|
|10194|**Knowledge Interaction Insight**|
|10197|**Knowledge article language setting**|
|10198|**Knowledge Article Attachment**|
|10201|**Knowledge search personal filter config**|
|10202|**Knowledge search filter**|
|10204|**SupportUserTable**|
|10205|**FxExpression**|
|10206|**PowerfxRule**|
|10207|**Planner Business Scenario**|
|10208|**Planner Sync Action**|
|10209|**Ms Graph Resource To Subscription**|
|10210|**Virtual Entity  Metadata**|
|10211|**Background Operation**|
|10212|**Report Parameter**|
|10213|**MobileOfflineProfileExtension**|
|10215|**TeamMobileOfflineProfileMembership**|
|10216|**UserMobileOfflineProfileMembership**|
|10217|**OrganizationDataSyncSubscription**|
|10218|**OrganizationDataSyncSubscriptionEntity**|
|10219|**OrganizationDataSyncSubscriptionFnoTable**|
|10220|**OrganizationDataSyncFnoState**|
|10221|**OrganizationDataSyncState**|
|10222|**ArchiveCleanupInfo**|
|10223|**ArchiveCleanupOperation**|
|10224|**BulkArchiveConfig**|
|10225|**BulkArchiveFailureDetail**|
|10226|**BulkArchiveOperation**|
|10227|**BulkArchiveOperationDetail**|
|10228|**EnableArchivalRequest**|
|10229|**MetadataForArchival**|
|10230|**ReconciliationEntityInfo**|
|10231|**ReconciliationEntityStepInfo**|
|10232|**ReconciliationInfo**|
|10233|**RetentionCleanupInfo**|
|10234|**RetentionCleanupOperation**|
|10235|**RetentionConfig**|
|10236|**RetentionFailureDetail**|
|10237|**RetentionOperation**|
|10238|**RetentionOperationDetail**|
|10239|**Notification**|
|10240|**User Rating**|
|10241|**Mobile App**|
|10242|**Insights Store Data Source**|
|10243|**Insights Store Virtual Entity**|
|10244|**RoleEditorLayout**|
|10245|**Deleted Record Reference**|
|10246|**Restore Deleted Records Configuration**|
|10247|**App Action**|
|10248|**App Action Migration**|
|10249|**App Action Rule**|
|10252|**Card**|
|10253|**Card State Item**|
|10256|**Entity link chat configuration**|
|10257|**Rich Text Attachment**|
|10260|**Virtual Connector Data Source**|
|10261|**Virtual Table Column Candidate**|
|10263|**PM Analysis History**|
|10264|**PM Business Rule Automation Config**|
|10265|**PM Calendar**|
|10269|**PM Process Template**|
|10270|**PM Process User Settings**|
|10271|**PM Process Version**|
|10272|**PM Recording**|
|10273|**PM Simulation**|
|10274|**PM Template**|
|10275|**PM View**|
|10276|**Analysis Component**|
|10277|**Analysis Job**|
|10278|**Analysis Override**|
|10279|**Analysis Result**|
|10280|**Analysis Result Detail**|
|10281|**Solution Health Rule**|
|10282|**Solution Health Rule Argument**|
|10283|**Solution Health Rule Set**|
|10284|**Power BI Dataset**|
|10285|**powerbidatasetapdx**|
|10286|**Power BI Mashup Parameter**|
|10287|**Power BI Report**|
|10288|**powerbireportapdx**|
|10289|**File Upload**|
|10290|**MainFewShot**|
|10291|**MakerFewShot**|
|10292|**SearchAttributeSettings**|
|10293|**SearchCustomAnalyzer**|
|10294|**SearchRelationshipSettings**|
|10295|**SearchResultsCache**|
|10296|**Search Telemetry**|
|10297|**ViewAsExampleQuestion**|
|10298|**CopilotExampleQuestion**|
|10308|**Invitation**|
|10309|**Invite Redemption**|
|10310|**Portal Comment**|
|10311|**Setting**|
|10312|**Multistep Form Session**|
|10316|**Ad Placement**|
|10317|**Column Permission**|
|10318|**Column Permission Profile**|
|10319|**Content Snippet**|
|10320|**Basic Form**|
|10321|**Basic Form Metadata**|
|10322|**List**|
|10323|**Table Permission**|
|10324|**Page Template**|
|10325|**Poll Placement**|
|10326|**Power Pages Core Entity DS**|
|10327|**Publishing State**|
|10328|**Publishing State Transition Rule**|
|10329|**Redirect**|
|10332|**Site Setting**|
|10333|**Web File**|
|10334|**Multistep Form**|
|10335|**Multistep Form Metadata**|
|10336|**Form Step**|
|10337|**Web Link**|
|10338|**Web Link Set**|
|10339|**Web Page**|
|10343|**Website Access**|
|10344|**Website Language**|
|10345|**Web Template**|
|10352|**Power Pages Scan Report**|
|10353|**Power Pages Log**|
|10359|**Package Submission Store**|
|10360|**List Operation**|
|10361|**Marketing Form Display Attributes**|
|10362|**Database Version**|
|10363|**Upgrade Run**|
|10364|**Upgrade Step**|
|10365|**Upgrade Version**|
|10366|**Activity monitor**|
|10367|**Originating Queue Mapping**|
|10368|**Unified Routing Setup Tracker**|
|10369|**Available Times**|
|10370|**Available Times Data Source**|
|10371|**resource group data source**|
|10372|**Virtual Resource Group Resource**|
|10373|**Migration tracker**|
|10374|**BgJobLedger**|
|10375|**Intent**|
|10376|**JobsState**|
|10377|**Asset Category Template Association**|
|10378|**Asset Template Association**|
|10379|**Customer Asset**|
|10382|**Customer Asset Attachment**|
|10383|**Customer Asset Category**|
|10384|**Functional Location**|
|10385|**Functional Location Type**|
|10386|**Location Template Association**|
|10387|**Functional Location Type Template Association**|
|10388|**Property Definition**|
|10389|**Property Asset Association**|
|10390|**Property Location Association**|
|10391|**Property Log**|
|10392|**Property Template Association**|
|10393|**Template For Properties**|
|10394|**Warranty**|
|10401|**IoT Alert**|
|10402|**IoT Device**|
|10403|**IoT Device Category**|
|10404|**IoT Device Command**|
|10405|**IoT Device Command Definition**|
|10406|**IoT Device Data History**|
|10407|**IoT Device Property**|
|10408|**IoT Device Registration History**|
|10409|**IoT Device Visualization Configuration**|
|10410|**IoT Field Mapping**|
|10411|**IoT Property Definition**|
|10412|**IoT Provider**|
|10413|**IoT Provider Instance**|
|10414|**IoT Settings**|
|10417|**IoT Alert to Case Process**|
|10419|**Playbook Callable Context**|
|10420|**Playbook activity**|
|10421|**Playbook activity attribute**|
|10422|**[DEPRECATED] Playbook category**|
|10423|**Playbook**|
|10424|**[DEPRECATED] Playbook template**|
|10426|**admin_settings_entity**|
|10427|**Collab Space Team Association**|
|10428|**CRM Connection**|
|10429|**Tagged Record**|
|10430|**Copilot for Sales customer list**|
|10431|**msdyn_vivaentitysetting**|
|10432|**msdyn_vivaorgextensioncred**|
|10433|**msdyn_vivaorgsetting**|
|10434|**msdyn_vivausersetting**|
|10435|**Sales Copilot Insight**|
|10436|**Org level settings for Sales Copilot apps**|
|10437|**Sales Copilot User Setting**|
|10438|**App profile**|
|10439|**Application Extension**|
|10440|**Application Tab Template**|
|10441|**App profile role mapping**|
|10442|**Notification Field**|
|10443|**Notification Template**|
|10444|**Session Template**|
|10445|**Template Parameter**|
|10451|**Channel Integration Framework v1.0 Provider**|
|10452|**Notification Field (Deprecated)**|
|10453|**Notification Template (Deprecated)**|
|10454|**App Parameter Definition (Deprecated)**|
|10455|**Session Templates (Deprecated)**|
|10456|**Application Tab Template (Deprecated)**|
|10457|**Parameter (Deprecated)**|
|10458|**Template Tag (Deprecated)**|
|10459|**Application Type (Deprecated)**|
|10468|**Channel Integration Framework v2.0 Provider**|
|10470|**Conversation Data (Deprecated)**|
|10471|**KPI Event Data**|
|10472|**KPI Event Definition**|
|10473|**Session Data (Deprecated)**|
|10474|**Session Participant Data (Deprecated)**|
|10475|**Channel Definition**|
|10476|**Channel Definition Consent**|
|10477|**Channel Definition Locale**|
|10478|**Channel Instance**|
|10479|**Channel Instance Account**|
|10480|**Channel Message Attachment**|
|10481|**Channel Message Context Part**|
|10482|**Channel Message Part**|
|10483|**Consuming Application**|
|10484|**msdyn_DefExtendedChannelInstance**|
|10485|**msdyn_DefExtendedChannelInstanceAccount**|
|10486|**Productivity pane configuration**|
|10487|**Pane tab configuration**|
|10488|**Pane tool configuration**|
|10490|**Agent script**|
|10491|**Agent script step**|
|10493|**Action Input Parameter**|
|10494|**Action Output Parameter**|
|10495|**Macro Action Template**|
|10496|**Macro Solution Configuration**|
|10497|**Macro Connector**|
|10498|**Macro Run History**|
|10499|**Parameter definition**|
|10502|**Adaptive Card Configuration**|
|10503|**Smartassist configuration**|
|10505|**Read Tracker**|
|10506|**Read tracking enabled information**|
|10507|**Microsoft Teams Graph resource Entity**|
|10508|**msdyn_msteamssetting**|
|10509|**msdyn_msteamssettingsv2**|
|10510|**Microsoft Teams Collaboration entity**|
|10511|**Teams Dialer Admin settings**|
|10512|**Teams Contact Suggestion by AI**|
|10513|**Contact suggestion rule**|
|10514|**Contact suggestion ruleset**|
|10515|**Microsoft Teams chat association entity**|
|10516|**Microsoft Teams chat suggestion**|
|10517|**Microsoft Orgchart node entity**|
|10518|**Forecast Manual Adjustment History**|
|10519|**Distributed Lock**|
|10520|**Entity Delta Change**|
|10521|**File Upload Status Tracker**|
|10522|**Forecast**|
|10523|**Forecast Configuration**|
|10524|**Forecast definition**|
|10525|**Forecasting Cache**|
|10526|**Forecast Insights**|
|10527|**Forecast**|
|10528|**Forecast Prediction Data**|
|10529|**Forecast Prediction Status**|
|10530|**Forecast recurrence**|
|10531|**Recompute Tracker**|
|10532|**Forecast Recurrence**|
|10533|**ShareAs Configuration**|
|10534|**Customer email communication**|
|10535|**GDPRData**|
|10536|**ODOSFeatureMetadata**|
|10537|**ODOSMetadata**|
|10538|**Recurring Sales Action**|
|10539|**Recurring Sales Action V2**|
|10540|**msdyn_relationshipinsightsunifiedconfig**|
|10541|**siconfig**|
|10542|**SI Key Value Config**|
|10543|**Usage Metric**|
|10544|**Action Card Regarding**|
|10545|**Action Card Role Setting**|
|10546|**EntityRankingRule**|
|10547|**flowcardtype**|
|10548|**salesinsightssettings**|
|10549|**Action Card Usage**|
|10550|**Action Card Usage Aggregation**|
|10551|**Auto Capture Rule**|
|10552|**Auto Capture Settings**|
|10553|**UntrackedAppointment**|
|10554|**Suggested Activity**|
|10555|**Suggested Activity Data Source**|
|10556|**Suggested Contact**|
|10557|**Suggested Contacts Data Source**|
|10558|**Notes analysis Config**|
|10559|**icebreakersconfig**|
|10560|**dealmanageraccess**|
|10561|**Deal manager settings**|
|10562|**Account KPI Item**|
|10563|**Activity Analysis CleanUp State**|
|10564|**Relationship Analytics Config**|
|10565|**Contact KPI Item**|
|10566|**Daily Kpis for account**|
|10567|**Daily kpis for contact**|
|10568|**Daily kpis for lead**|
|10569|**Daily kpis for Opportunity**|
|10570|**Lead KPI Item**|
|10571|**Most Contacted**|
|10572|**Most Contacted By**|
|10573|**Opportunity KPI Item**|
|10574|**Relationship Analytics Metadata**|
|10575|**Similar entities feature importance**|
|10576|**wkwcolleaguesforcompany**|
|10577|**wkwcolleaguesforcontact**|
|10578|**wkwconfig**|
|10579|**Attribute Influence Statistics**|
|10580|**Prediction Computation Operation**|
|10581|**Prediction Model Status**|
|10582|**Prediction Scheduled Operation**|
|10583|**Predictive Model Score**|
|10584|**Predictive Score**|
|10585|**Predictive Scoring Sync Status**|
|10586|**Real Time Scoring**|
|10587|**Real Time Scoring Operation**|
|10588|**Submodel Definition**|
|10589|**Time spent in BPF**|
|10590|**Training Result**|
|10591|**OpportunityModelConfig**|
|10592|**LeadModelConfig**|
|10593|**ModelPreviewStatus**|
|10594|**Profile Album**|
|10595|**Post Configuration**|
|10596|**Post Rule Configuration**|
|10597|**Wall View**|
|10598|**Filter**|
|10599|**Customer Voice alert**|
|10600|**Customer Voice alert rule**|
|10601|**Customer Voice survey email template**|
|10602|**Customer Voice file response**|
|10603|**Customer Voice localized survey email template**|
|10604|**Customer Voice project**|
|10605|**Customer Voice survey question**|
|10606|**Customer Voice survey question response**|
|10607|**Customer Voice satisfaction metric**|
|10608|**Customer Voice survey**|
|10609|**Customer Voice survey invite**|
|10610|**Customer Voice survey reminder**|
|10611|**Customer Voice survey response**|
|10612|**Customer Voice unsubscribed recipient**|
|10613|**Customer Service Key Value Configuration**|
|10614|**AddToCalendar style**|
|10615|**basestyle**|
|10616|**Button style**|
|10617|**Code style**|
|10618|**Column style**|
|10619|**Content Block**|
|10620|**Divider style**|
|10621|**General styles**|
|10622|**imagestyle**|
|10623|**Layout Style**|
|10624|**QR code style**|
|10625|**Text style**|
|10626|**Video style**|
|10627|**App state**|
|10628|**CSAdminConfig**|
|10629|**Custom API Ruleset Configuration**|
|10630|**Decision contract**|
|10631|**Decision rule set**|
|10632|**Rulesetentitymapping**|
|10633|**Routing diagnostic item**|
|10634|**Routing diagnostic**|
|10635|**Inbox card configuration**|
|10636|**Inbox Configuration**|
|10637|**Inbox Entity Configuration**|
|10638|**App Profile Copilot Configuration**|
|10639|**Swarm**|
|10640|**Swarm participant**|
|10641|**Swarm participant rule**|
|10642|**Swarm role**|
|10643|**Swarm skill**|
|10644|**Swarm template**|
|10645|**Autonomous case creation and enrichment rules**|
|10646|**Entity Attachment**|
|10647|**Time Tracker**|
|10648|**Survey setting**|
|10649|**Master Entity Routing Configuration**|
|10650|**Routing Rule Set Setting**|
|10651|**Assignment Configuration**|
|10652|**Assignment Configuration Step**|
|10653|**Capacity Profile**|
|10654|**Overflow Action Config**|
|10655|**Preferred Agent**|
|10656|**Preferred Agent Customer Identity**|
|10657|**Preferred Agent Routed Entity**|
|10658|**Routing configuration**|
|10659|**Routing configuration step**|
|10660|**Bot Channel Registration**|
|10661|**Channel Configuration**|
|10662|**Channel State Configuration**|
|10663|**Provisioning State**|
|10664|**AdminAppState**|
|10665|**Agent Status history**|
|10666|**Power BI Configuration**|
|10667|**Authentication Settings**|
|10668|**Auth Settings Entry**|
|10669|**Quick reply**|
|10670|**Entity Routing Context**|
|10671|**Channel Capability**|
|10672|**Conversation Action**|
|10673|**Conversation Action Locale**|
|10674|**Conversation Message Block**|
|10675|**DeletedConversation**|
|10676|**Deprecated Workstream Entity Configuration**|
|10677|**Entity**|
|10678|**Ongoing conversation (Deprecated)**|
|10679|**Live work item event**|
|10680|**Work Stream**|
|10681|**Masking Rule**|
|10682|**Auto block rule**|
|10683|**Bot Channel Registration Secret**|
|10684|**Omnichannel channel api conversation privilege**|
|10685|**Omnichannel channel api message privilege**|
|10686|**Channel api method mapping**|
|10687|**External context**|
|10688|**Flagged spam**|
|10689|**Language**|
|10690|**Conversation**|
|10693|**Context item value**|
|10694|**Live Work Item Participant (Deprecated)**|
|10695|**Conversation Sentiment**|
|10696|**Context variable**|
|10697|**Localization**|
|10698|**OC Payment Profile**|
|10699|**Recording**|
|10700|**Omnichannel Request**|
|10701|**Rich message**|
|10702|**Rich message map**|
|10703|**Rule Item**|
|10704|**Sentiment daily topic**|
|10705|**Sentiment daily topic keyword**|
|10706|**Sentiment daily topic trending**|
|10707|**Session**|
|10708|**Session Participant Event**|
|10709|**Session Sentiment**|
|10710|**Message**|
|10711|**Tag**|
|10712|**Geo Location Provider**|
|10713|**Omnichannel Configuration**|
|10714|**Omnichannel Personalization**|
|10715|**Omnichannel Queue (Deprecated)**|
|10716|**Omnichannel Sync Config**|
|10717|**Operating Hour**|
|10718|**Personal quick reply**|
|10719|**Personal sound setting**|
|10720|**Persona Security Role Mapping**|
|10721|**Presence**|
|10722|**Provider**|
|10723|**RoutingRequest**|
|10724|**Search Configuration**|
|10725|**Sentiment analysis**|
|10726|**Session event**|
|10727|**Session participant**|
|10728|**Audio File**|
|10729|**Sound notification setting**|
|10730|**Transcript**|
|10731|**UR notification template**|
|10732|**UR Notification Template Mapping**|
|10733|**User settings**|
|10734|**Self service**|
|10741|**Agent capacity update history**|
|10742|**Bookable Resource Capacity Profile**|
|10743|**Work stream capacity profile**|
|10744|**Conversation Capacity profile**|
|10745|**Agent Capacity Profile Unit**|
|10746|**Agent Channel State**|
|10747|**Agent Status**|
|10748|**Conversation Characteristic**|
|10749|**Session Characteristic**|
|10750|**Skill Attachment Rule**|
|10751|**Attach Skill**|
|10752|**Model training details**|
|10753|**Training data import configuration**|
|10754|**Characteristic mapping**|
|10755|**Training record**|
|10756|**Skill finder model**|
|10757|**Effort estimate**|
|10758|**Effort estimation model**|
|10759|**Effort model training details**|
|10760|**ConversationInsight**|
|10761|**Active ICD Extension**|
|10762|**Entity-Workstream Map**|
|10763|**ICD Extension**|
|10764|**Lock Status**|
|10765|**Omnichannel agent assignment custom api privilege**|
|10766|**Conversation Action Item**|
|10767|**Conversation Aggregated Insights**|
|10768|**Comment**|
|10769|**Conversation Participant Insights**|
|10770|**Conversation Participant Sentiment**|
|10771|**Conversation Question**|
|10772|**Conversation Segment Sentiment**|
|10773|**Conversation Sentiment**|
|10774|**Conversation Signal**|
|10775|**Conversation Subject**|
|10776|**Conversation Summary Suggestion**|
|10777|**Conversation System Tag**|
|10778|**Conversation Tag**|
|10779|**Recording**|
|10780|**SCI Conversation**|
|10781|**Custom Email Highlight**|
|10782|**Custom Highlight**|
|10783|**Custom Publisher**|
|10784|**EnvironmentSettings**|
|10785|**UserSettings**|
|10786|**CatalogEventStatusConfiguration**|
|10787|**Configuration**|
|10788|**Trigger**|
|10789|**Triggers To Sdk Message Processing Steps**|
|10790|**EventParameterMetadata**|
|10791|**TrackingContext**|
|10792|**Marketing feature configuration**|
|10793|**msdynmkt_experimentv2**|
|10794|**ACS channel instance**|
|10795|**ACS channel instance account**|
|10796|**Infobip channel instance**|
|10797|**Infobip channel instance account**|
|10798|**Link mobility channel instance**|
|10799|**Link mobility channel instance account**|
|10800|**MockSmsProvider channel instance**|
|10801|**MockSmsProvider channel instance account**|
|10802|**TeleSign channel instance**|
|10803|**TeleSign channel instance account**|
|10804|**Twilio channel instance**|
|10805|**Twilio channel instance account**|
|10806|**Vibes channel instance**|
|10807|**Vibes channel instance account**|
|10808|**Predefined Placeholder**|
|10809|**Metadata Entity Relationship**|
|10810|**Metadata Item**|
|10811|**Metadata Store State**|
|10812|**DigitalSellingActiveTask**|
|10813|**DigitalSellingCompletedTask**|
|10814|**Sales Tag**|
|10815|**Sequence**|
|10816|**Sequence Stat**|
|10817|**Sequence Target**|
|10818|**Sequence Target Step**|
|10819|**Sequence Template**|
|10821|**sabackupdiagnostic**|
|10822|**SABatchRunInstance**|
|10823|**salesroutingdiagnostic**|
|10824|**SARunInstance**|
|10825|**Segment**|
|10826|**segmentsetting**|
|10827|**Segment property**|
|10828|**SegmentsUtil**|
|10829|**Assignment Rule**|
|10830|**Seller attribute**|
|10831|**Seller attribute value**|
|10832|**Assignment Map**|
|10833|**Sales Assignment Setting**|
|10834|**Sales routing run**|
|10836|**Extended User Setting**|
|10837|**Sales acceleration insights**|
|10838|**Sales Acceleration settings**|
|10839|**Insight**|
|10840|**Work List Suggestion**|
|10841|**Work list suggestion source**|
|10842|**Work List View Configuration**|
|10843|**Work Queue Record**|
|10844|**Work Queue Record State**|
|10845|**Work list user setting**|
|10846|**WQDataSource**|
|10847|**Suggestion Assignment Rule**|
|10848|**Suggestion Principal Object Access**|
|10849|**Suggestion Seller Priority**|
|10850|**Data Hygiene Setting Info**|
|10851|**Duplicate Detection Plugin Run**|
|10852|**Duplicate Lead Mapping**|
|10853|**Lead Hygiene Setting**|
|10854|**Linked Entity Attribute Validity**|
|10855|**Sales provisioning request**|
|10856|**SalesOmnichannel Message**|
|10857|**Text message template**|
|10858|**Data Analytics Admin Settings (Deprecated)**|
|10859|**Data Analytics Report**|
|10860|**Insights**|
|10861|**Sales acceleration reports**|
|10863|**Bot Session**|
|10864|**Agent Copilot Setting**|
|10865|**Copilot Summarization Setting**|
|10866|**Case Enrichment**|
|10867|**Case follow up and closure configuration**|
|10868|**Case Suggestion**|
|10869|**Case Suggestion Request Payload**|
|10870|**Case Suggestions Data Souce**|
|10871|**Agent Preference For Copilot**|
|10872|**Copilot Interaction**|
|10873|**Copilot Interaction Data**|
|10874|**Copilot Transcript**|
|10875|**Copilot Transcript Data**|
|10876|**KB Enrichment**|
|10877|**Knowledge Article Suggestion**|
|10878|**Knowledge Article Suggestion Data Source**|
|10879|**Next Action**|
|10880|**Service Copilot Plugin**|
|10881|**Service Copilot Plugin Role**|
|10882|**Suggestion Interaction**|
|10883|**Suggestion request payload**|
|10884|**Suggestions Model Summary**|
|10885|**Suggestions Setting**|
|10886|**Data Analytics User Customized Report**|
|10887|**Data Analytics Dataset**|
|10888|**Data Analytics Workspace**|
|10889|**Report Bookmark**|
|10890|**Agent Resource Forecasting**|
|10891|**[Deprecated] Dynamics Customer Service Analytics**|
|10892|**Case Topic**|
|10893|**Case Topic Setting**|
|10894|**Case Topic Summary**|
|10895|**Case topic Incident mapping**|
|10896|**Customer Service historical analytics**|
|10897|**Forecast**|
|10898|**Knowledge analytics**|
|10899|**Forecast Summary and Setting**|
|10900|**Keywords Description Suggestion Setting**|
|10901|**Conversation Summary Interaction**|
|10902|**Conversation Summary Setting**|
|10903|**Conversation Topic**|
|10904|**Conversation Topic Setting**|
|10905|**Conversation Topic Summary**|
|10906|**Conversation topic Conversation mapping**|
|10907|**Omnichannel historical analytics**|
|10908|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|10909|**Omnichannel Realtime analytics**|
|10980|**Configuration**|
|10981|**Client Extension**|
|10982|**Booking Setup Metadata**|
|10983|**Requirement Characteristic**|
|10984|**Requirement Group**|
|10985|**Bookable Resource Association**|
|10986|**Actual**|
|10987|**Three-Dimensional Model**|
|10988|**Booking Alert**|
|10989|**Booking Alert Status**|
|10990|**Booking Change**|
|10991|**Booking Rule**|
|10992|**Business Closure**|
|10993|**Organizational Unit**|
|10994|**Priority**|
|10995|**Requirement Organization Unit**|
|10996|**Requirement Relationship**|
|10997|**Requirement Resource Category**|
|10998|**Requirement Resource Preference**|
|10999|**Requirement Status**|
|11000|**Resource Requirement**|
|11001|**Resource Requirement Detail**|
|11002|**Resource Territory**|
|11003|**Schedule Board Setting**|
|11004|**Scheduling Parameter**|
|11005|**System User Scheduler Setting**|
|11006|**Fulfillment Preference**|
|11007|**Time Group Detail**|
|11008|**Transaction Origin**|
|11009|**Work Template**|
|11010|**Optimization Request**|
|11011|**Requirement Change**|
|11012|**Requirement Dependency**|
|11013|**Scheduling Feature Flag**|
|11014|**Inspection Template**|
|11015|**Inspection Attachment**|
|11016|**Inspection Template Version**|
|11017|**Inspection**|
|11018|**Inspection Response**|
|11019|**Time Entry**|
|11020|**Time Source**|
|11021|**Payment Term**|
|11022|**Purchase Order**|
|11023|**Purchase Order Product**|
|11024|**Purchase Order Receipt**|
|11025|**Purchase Order Receipt Product**|
|11026|**Ship Via**|
|11027|**Tax Code**|
|11028|**Tax Code Detail**|
|11029|**Warehouse**|
|11030|**Agreement**|
|11031|**Agreement Booking Date**|
|11032|**Agreement Booking Incident**|
|11033|**Agreement Booking Product**|
|11034|**Agreement Booking Service**|
|11035|**Agreement Booking Service Task**|
|11036|**Agreement Booking Setup**|
|11037|**Agreement Invoice Date**|
|11038|**Agreement Invoice Product**|
|11039|**Agreement Invoice Setup**|
|11040|**Agreement Substatus**|
|11041|**Booking Journal**|
|11042|**Booking Timestamp**|
|11043|**Purchase Order Business Process**|
|11044|**Case to Work Order Business Process**|
|11045|**Agreement Business Process**|
|11046|**Work Order Business Process**|
|11047|**Entitlement Application**|
|11048|**Field Service Price List Item**|
|11049|**Field Service Setting**|
|11050|**Field Service SLA Configuration**|
|11051|**Field Service System Job**|
|11052|**Incident Type**|
|11053|**Incident Type Characteristic**|
|11054|**Incident Type Product**|
|11055|**Incident Type Service**|
|11056|**Incident Type Service Task**|
|11057|**Incident Types Setup**|
|11058|**Incident Type Requirement Group**|
|11059|**Inventory Adjustment**|
|11060|**Inventory Adjustment Product**|
|11061|**Inventory Journal**|
|11062|**Inventory Transfer**|
|11063|**Order Invoicing Date**|
|11064|**Order Invoicing Product**|
|11065|**Order Invoicing Setup**|
|11066|**Order Invoicing Setup Date**|
|11067|**Payment**|
|11068|**Payment Detail**|
|11069|**Payment Method**|
|11070|**Postal Code**|
|11071|**Product Inventory**|
|11072|**Purchase Order Bill**|
|11073|**Purchase Order SubStatus**|
|11074|**Quote Booking Incident**|
|11075|**Quote Booking Product**|
|11076|**Quote Booking Service**|
|11077|**Quote Booking Service Task**|
|11078|**Quote Booking Setup**|
|11079|**Quote Invoicing Product**|
|11080|**Quote Invoicing Setup**|
|11081|**Resource Pay Type**|
|11082|**RMA**|
|11083|**RMA Product**|
|11084|**RMA Receipt**|
|11085|**RMA Receipt Product**|
|11086|**RMA SubStatus**|
|11087|**RTV**|
|11088|**RTV Product**|
|11089|**RTV Substatus**|
|11090|**Service Task Type**|
|11091|**Time Off Request**|
|11092|**Unique Number**|
|11093|**Work Order**|
|11094|**Work Order Characteristic (Deprecated)**|
|11095|**Work Order Details Generation Queue (Deprecated)**|
|11096|**Work Order Incident**|
|11097|**Work Order Product**|
|11098|**Resource Restriction (Deprecated)**|
|11099|**Work Order Service**|
|11100|**Work Order Service Task**|
|11101|**Work Order Substatus**|
|11102|**Work Order Type**|
|11104|**Bookable Resource Booking Quick Note**|
|11105|**Field Service Frontline Worker Configuration**|
|11108|**Incident Type Suggestion Result**|
|11109|**Incident Type Suggestion Run History**|
|11110|**Incident Type Resolution**|
|11111|**Insurance**|
|11112|**Not-to-exceed**|
|11113|**Asset Suggestion**|
|11114|**Problematic Asset Feedback**|
|11115|**Resolution**|
|11116|**Trade**|
|11117|**Trade Coverage**|
|11120|**Work order not-to-exceed**|
|11121|**Work Order Resolution**|
|11122|**CFS - IoT Alert Process Flow**|
|11123|**Geolocation Settings**|
|11124|**Geolocation Tracking**|
|11125|**Entity Configuration**|
|11126|**Geofence**|
|11127|**Geofence Event**|
|11128|**Geofencing Settings**|
|11129|**Asset Suggestions Setting**|
|11130|**Field service historical analytics**|
|11131|**Resource duration (preview)**|
|11132|**Predictive duration (preview)**|
|11133|**Predictive Work Hour Duration Setting**|
|11134|**Field Service Summary Configuration**|
|11135|**MobileSource**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)

### <a name="BKMK_msdyn_bookingalert_sla_slaid"></a> msdyn_bookingalert_sla_slaid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_sla_slaid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slaid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`slaid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_sla_slaid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `7f15e2bb-305a-468f-9af7-be865755a984`|

### <a name="BKMK_msdyn_bookingalert_sla_slainvokedid"></a> msdyn_bookingalert_sla_slainvokedid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_sla_slainvokedid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slainvokedid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`slainvokedid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_sla_slainvokedid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
