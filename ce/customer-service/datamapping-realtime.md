---
title: Data mapping for real-time analytics
description: Learn about data mapping for real-time analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 06/06/2023
ms.custom: bap-template
---

# Data mapping for real-time analytics

This article describes the DAX logic for the real-time metrics. For details on real-time metrics, go to [Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)

## FactConversation

<table border="1">
    <tbody>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Attribute Name&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>DAX logic&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Abandoned conversations&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Abandoned conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;FactConversation[IsAbandoned]&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;FactConversation[StatusCode]&nbsp;==&nbsp;4&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;NOT&nbsp;FactConversation[DirectionCode],&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;1,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;0&nbsp;</p>
                    </div>
                    <div>
                        <p>        )&nbsp;</p>
                    </div>
                    <div>
                        <p>    )&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Abandoned rate&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Aband&nbsp;</p>
                        <div><br></div>
                        <div><br></div>
                        <div><img src="https://c4-word-edit-15.cdn.office.net/we/s/h83987E0F63D43F20_resources/1033/we_version2.png" alt="Paragraph locked by Venkat Anantharaman" title="Paragraph locked by Venkat Anantharaman"></div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Active conversations awaiting agent acceptance&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Active conversations awaiting agent acceptance =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;FactConversation[statuscode]&nbsp;=&nbsp;2&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;FactConversation[StatusReason]&nbsp;==&nbsp;&quot;Agent assigned, awaiting acceptance&quot;,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;1,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;0&nbsp;</p>
                    </div>
                    <div>
                        <p>        )&nbsp;</p>
                    </div>
                    <div>
                        <p>    )&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Active conversations with agent acceptance&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Active conversations with agent acceptance =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;FactConversation[statuscode]&nbsp;=&nbsp;2&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;FactConversation[StatusReason]&nbsp;==&nbsp;&quot;In conversation&quot;,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;1,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;0&nbsp;</p>
                    </div>
                    <div>
                        <p>        )&nbsp;</p>
                    </div>
                    <div>
                        <p>    )&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation first wait time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation first wait time (sec) =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;AVERAGEX(FactConversation,&nbsp;IF(NOT&nbsp;FactConversation[DirectionCode],&nbsp;BLANK(),&nbsp;FactConversation[ConversationFirstWaitTimeInSeconds]&nbsp;))&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation hold time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation hold time (sec) =&nbsp;AVERAGE(FactConversation[ConversationHoldTimeInSeconds])&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg.&nbsp;conversation&nbsp;talk time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation talk time (sec) =&nbsp;AVERAGE(FactConversation[ConversationTalkTimeInSeconds])&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation time (sec) =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>AVERAGE&nbsp;(&nbsp;FactConversation[ConversationTimeInSeconds]&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation wrap up time&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. conversation wrap up time =&nbsp;AVERAGE(FactConversation[ConversationWrapUpTimeInSeconds])&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. handle time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. handle time (sec) =&nbsp;AVERAGE(FactConversation[ConversationHandleTimeInSeconds])&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. speed to answer time (hh:mm:ss)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. speed to answer time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. speed to answer time (sec) =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>AVERAGEX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation[IsAgentAccepted]&nbsp;</p>
                    </div>
                    <div>
                        <p>            &amp;&amp;&nbsp;NOT&nbsp;FactConversation[DirectionCode],&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation[ConversationSpeedToAnswerInSeconds],&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;BLANK&nbsp;()&nbsp;</p>
                    </div>
                    <div>
                        <p>    )&nbsp;</p>
                    </div>
                    <div>
                        <p>)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Avg. wait time&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Closed&nbsp;conversation&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Closed conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;FactConversation,&nbsp;IF&nbsp;(&nbsp;FactConversation[StatusCode]&nbsp;==&nbsp;4,&nbsp;1,&nbsp;0&nbsp;)&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conv. time&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversation first&nbsp;wait&nbsp;time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversation first&nbsp;wait&nbsp;time (sec) =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;NOT&nbsp;FactConversation[DirectionCode],&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation[ConversationFirstWaitTimeInSeconds],&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;BLANK&nbsp;()&nbsp;</p>
                    </div>
                    <div>
                        <p>    )&nbsp;</p>
                    </div>
                    <div>
                        <p>)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversation handle time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversation handle time (sec) =&nbsp;SUM(FactConversation[ConversationHandleTimeInSeconds])&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversation id&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Attribute&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversations in queue&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Conversations in queue =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;NOT&nbsp;FactConversation[DirectionCode]&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;(&nbsp;FactConversation[StatusCode]&nbsp;==&nbsp;1&nbsp;</p>
                    </div>
                    <div>
                        <p>                ||&nbsp;(&nbsp;FactConversation[StatusCode]&nbsp;==&nbsp;2&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;FactConversation[StatusReason]&nbsp;==&nbsp;&quot;Agent assigned, awaiting acceptance&quot;&nbsp;)&nbsp;),&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;1,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;0&nbsp;</p>
                    </div>
                    <div>
                        <p>        )&nbsp;</p>
                    </div>
                    <div>
                        <p>    )&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>ConversationTalkTimeInSeconds&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Attribute&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Created on&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Attribute&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Incoming conversation&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Incoming conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;FactConversation,&nbsp;IF&nbsp;(&nbsp;NOT&nbsp;FactConversation[DirectionCode],&nbsp;1,&nbsp;0&nbsp;)&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Longest wait time (sec)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Longest wait time (sec) =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>MAXX(FactConversation,&nbsp;IF(NOT&nbsp;FactConversation[DirectionCode],&nbsp;FactConversation[CurrentWaitTimeInSeconds],&nbsp;BLANK()))&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Ongoing conversations&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Ongoing conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p> SUMX&nbsp;(&nbsp;FactConversation,&nbsp;IF&nbsp;(&nbsp;FactConversation[IsOngoing],&nbsp;1,&nbsp;0&nbsp;)&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Open conversations&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Open conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;FactConversation,&nbsp;IF&nbsp;(&nbsp;FactConversation[statuscode]&nbsp;==&nbsp;1,&nbsp;1,&nbsp;0&nbsp;)&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Sentiment&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Attribute&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (10 seconds)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (10 seconds) =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>DIVIDE&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;FactConversation[ConversationFirstWaitTimeInSeconds]&nbsp;&lt;=&nbsp;10&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;FactConversation[IsAgentAccepted]&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;NOT&nbsp;FactConversation[DirectionCode],&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;1,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;0&nbsp;</p>
                    </div>
                    <div>
                        <p>        )&nbsp;</p>
                    </div>
                    <div>
                        <p>    ),&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;FactConversation,&nbsp;</p>
                    </div>
                    <div>
                        <p>       &nbsp;IF&nbsp;(&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;FactConversation[IsAgentAccepted]&nbsp;</p>
                    </div>
                    <div>
                        <p>                &amp;&amp;&nbsp;NOT&nbsp;FactConversation[DirectionCode],&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;1,&nbsp;</p>
                    </div>
                    <div>
                        <p>           &nbsp;0&nbsp;</p>
                    </div>
                    <div>
                        <p>        )&nbsp;</p>
                    </div>
                    <div>
                        <p>    ),&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;BLANK&nbsp;()&nbsp;</p>
                    </div>
                    <div>
                        <p>)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (120 seconds)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (20 seconds)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Similar to service level (10 seconds)&nbsp;</p>
                        <div><br></div>
                        <div><br></div>
                        <div><img src="https://c4-word-edit-15.cdn.office.net/we/s/h83987E0F63D43F20_resources/1033/we_version2.png" alt="Paragraph locked by Venkat Anantharaman" title="Paragraph locked by Venkat Anantharaman"></div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (30 seconds)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Similar to service level (10 seconds)&nbsp;</p>
                        <div><br></div>
                        <div><br></div>
                        <div><img src="https://c4-word-edit-15.cdn.office.net/we/s/h83987E0F63D43F20_resources/1033/we_version2.png" alt="Paragraph locked by Venkat Anantharaman" title="Paragraph locked by Venkat Anantharaman"></div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (40 seconds)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Similar to service level (10 seconds)&nbsp;</p>
                        <div><br></div>
                        <div><br></div>
                        <div><img src="https://c4-word-edit-15.cdn.office.net/we/s/h83987E0F63D43F20_resources/1033/we_version2.png" alt="Paragraph locked by Venkat Anantharaman" title="Paragraph locked by Venkat Anantharaman"></div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Service level (60 seconds)&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Similar to Service level (10 seconds)&nbsp;</p>
                        <div><br></div>
                        <div><br></div>
                        <div><img src="https://c4-word-edit-15.cdn.office.net/we/s/h83987E0F63D43F20_resources/1033/we_version2.png" alt="Paragraph locked by Venkat Anantharaman" title="Paragraph locked by Venkat Anantharaman"></div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Title&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Attribute&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Total conversations&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Total conversations =&nbsp;COUNTROWS(FactConversation)&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Waiting conversations&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Waiting conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;FactConversation,&nbsp;IF&nbsp;(&nbsp;FactConversation[statuscode]&nbsp;==&nbsp;3,&nbsp;1,&nbsp;0&nbsp;)&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Wrap-up conversations&nbsp;</p>
                    </div>
                </div>
            </td>
            <td>
                <div><br></div>
                <div><br></div>
                <div>
                    <div>
                        <p>Wrap-up conversations =&nbsp;&nbsp;</p>
                    </div>
                    <div>
                        <p>   &nbsp;SUMX&nbsp;(&nbsp;FactConversation,&nbsp;IF&nbsp;(&nbsp;FactConversation[statuscode]&nbsp;==&nbsp;5,&nbsp;1,&nbsp;0&nbsp;)&nbsp;)&nbsp;</p>
                    </div>
                    <div>
                        <p>&nbsp;</p>
                    </div>
                </div>
            </td>
        </tr>
    </tbody>
</table>





## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
