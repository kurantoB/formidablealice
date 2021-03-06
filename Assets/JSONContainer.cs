﻿public class JSONContainer
{
    public static string prologueJSON = @"{
	""lines"": [
		""(Tip: Press the spacebar to read dialogue.)"",
		""Marisa: Hey, Reimu!"",
		""Reimu: Yeah?"",
		""Marisa: I'mma need your blessing today. I need all the luck I can get!"",
		""Marisa: Cause today is the day I ask her out!"",
		""Reimu: Oh... Remind me again what sort of blessing you need for that?"",
		""Marisa: Aren't 'cha supposed to know these things?"",
		""Marisa: Ya know, the way a doctor writes a prescription and sends me on my way?"",
		""Reimu: (Waves gohei) Oh divine god of love or somethingorother, bestow thy will on this poor soul."",
		""Marisa: Does love and romance mean anythin' at all to ya?"",
		""Reimu: Of course. It means you finally spend time with your SO instead of crashing my place all the time."",
		""Marisa: D-Don't talk about it as if I have it in the bag already...!"",
		""Reimu: In all seriousness, I don't know how you can handle Alice. But, you do you, right?"",
		""Marisa: Don't feel too lonely while I'm gone. I'll let you know how it goes!"",
		""Reimu: Well. If you're actually being sincere, then good luck."",
		""Marisa: Wahoo! Golly gee.. (Ba-dump) My heart is pounding!"",
		""Marisa: Ok! Here we go!"",
		""(With a gust of wind, Marisa was in the air, zooming towards the Forest of Magic for another one of her many idle banters with the doll magician.)"",
		""(Will it be different this time? Only time will tell!)"",
		""Rules: There are keywords that automatically scroll up on the right."",
		""Rules: They are randomly-generated. Click them to introduce a new topic in your conversation."",
		""Rules: If you introduce the wrong topic at the wrong time, your conversation will be shortened!""
	]
    }";

    public static string gameJSON = @"{
	""topics"": [
		{
			""topic"": ""Borrowing"",
			""leadIns"": [ ""Subterranean Animism"", ""Dolls"" ],
			""casualTalk"": {
				""alicesOpening"": {
					""line"": ""Alice: Are you going to ask me for help in borrowing something?"",
					""mugshot"": ""A_Inquisitive""
				},
				""lines"": [
					{
						""line"": ""Marisa: Man, I'm so bored. I just might find something to borrow! Interested?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: If... you're going to let me work with you just this once, I might as well."",
						""mugshot"": ""A_Side""
					},
					{
						""line"": ""Marisa: Now y'er just encouragin' me."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: But actually, I'm so good at borrowing that it's hard to find things that are worth the challenge."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Marisa: That's why I'm not doin' it as much nowadays."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Well, at long last. I might as well tell everyone to leave their doors wide open."",
						""mugshot"": ""A_Drama""
					},
					{
						""line"": ""Marisa: Obviously, I was lying."",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Marisa: The world's never short on things to borrow."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Oh dear. I <i>should've</i> seen that coming."",
						""mugshot"": ""A_Sad""
					},
					{
						""line"": ""Marisa: (Grin)"",
						""mugshot"": ""M_Grin""
					}
				],
				""pointMade"": 7
			},
			""realTalk"": {
				""alicesOpening"": {
					""line"": ""Why don't you tell me about the latest thing in your 'borrow' list?"",
					""mugshot"": ""A_Happy""
				},
				""lines"": [
					{
						""line"": ""Marisa: There's somethin' I've been wantin' to wanna borrow lately."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: And it's something that gets you excited enough to tell me about it?"",
						""mugshot"": ""A_Inquisitive""
					},
					{
						""line"": ""Marisa: I wouldn't make light of it. I had to convince myself that I want it too."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Ugh. And somehow <i>I'm</i> the drama queen."",
						""mugshot"": ""A_Drama""
					},
					{
						""line"": ""Marisa: Ya ever wondered if there's something as precious to me..."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: ...as your doll research is to you?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Oh... I wouldn't have known."",
						""mugshot"": ""A_Neutral""
					},
					{
						""line"": ""Marisa: (Sweats)"",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Do you need my help in borrowing it?"",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: I did say earlier that I ought'a borrow more things from ya."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Wait. W-Where is this going?"",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Marisa: That's a good question..."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: ..."",
						""mugshot"": ""A_Inquisitive""
					}
				],
				""pointMade"": 10
			}
		},
		{
			""topic"": ""Rinnosuke"",
			""casualTalk"": {
				""alicesOpening"": {
					""line"": ""Alice: Hey, have you talked to the weirdo who's always hoarding items?"",
					""mugshot"": ""A_Happy""
				},
				""lines"": [
					{
						""line"": ""Marisa: I stopped by Kourindou the other day."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: The weirdo who's always hoarding items?"",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: The way you describe it... Well if it ain't me, it's Rinnosuke."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: I'm sure he has lots of materials for my doll research."",
						""mugshot"": ""A_Neutral""
					},
					{
						""line"": ""Alice: But he's so hard to approach."",
						""mugshot"": ""A_Sad""
					},
					{
						""line"": ""Marisa: Yeah, not the friendliest."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: It sure takes guts for you to step inside the shop, being a known thief and all."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: Geez, get me off this pedestal."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Oh it's a pedestal all right. A pedestal for honoring thieves."",
						""mugshot"": ""A_Drama""
					},
					{
						""line"": ""Marisa: So anyway, Rinnosuke was just tellin' me."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: How frustratin' it is to be not quite human, and also not quite youkai either."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: He said it's hard to know the value of life, given how long it is."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: And since it's still a short life for a youkai, he feels kinda restricted."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Oh, that's interesting. I've never thought of it that way."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: Ya better go visit his shop at least once before he kicks the bucket."",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Alice: Why would I do that when I can just ask <i>you</i> to go there for me?"",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: (Frown)"",
						""mugshot"": ""M_Sad""
					}
				],
				""pointMade"": 13
			}
		},
		{
			""topic"": ""Evil Scheme"",
			""leadIns"": [ ""Borrowing"", ""Rinnosuke"" ],
			""casualTalk"": {
				""alicesOpening"": {
					""line"": ""Alice: So, you seem awfully free these days."",
					""mugshot"": ""A_Happy""
				},
				""lines"": [
					{
						""line"": ""Marisa: I want to tell you somethin'. It's about my super amazing deadly evil scheme."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: But you seem awfully free these days."",
						""mugshot"": ""A_Side""
					},
					{
						""line"": ""Marisa: Why thank you, it's hard puttin' up this facade."",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Marisa: Just wait till you hear about it. My super deadly evil schem-o."",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Alice: Okay... What evil scheme are you working on?"",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: It's also called, my super deadly <i>secret</i> evil schem-o."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Okay, Miss 'I'm gonna tell you all about it.'"",
						""mugshot"": ""A_Drama""
					},
					{
						""line"": ""Marisa: Haha... Gotcha there...! Haha."",
						""mugshot"": ""M_Exasperated""
					}
				],
				""pointMade"": 6
			},
			""realTalk"": {
				""alicesOpening"": {
					""line"": ""Are you living up to your evil witch identity? You know, maybe stealing's not enough."",
					""mugshot"": ""A_Happy""
				},
				""lines"": [
					{
						""line"": ""Marisa: I still didn't tell ya about my evil scheme."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Your evil scheme better involve something beyond stealing."",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: Good point."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: I was thinkin' about what Rinnosuke said, and he's kinda right."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: I've got nothin' on all you youkai. Just a short-lived human right here."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Marisa: No matter how good you are at borrowing, ya can't borrow more time."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: ..."",
						""mugshot"": ""A_Side""
					},
					{
						""line"": ""Alice: Oh please. What's with all this gloom and doom?"",
						""mugshot"": ""A_Side""
					},
					{
						""line"": ""Marisa: Hey, I'm not sad about it. There's always somethin' to make it worthwhile."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: That's exactly what my evil scheme is for."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: This better not be some half-baked treachery."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: Don' 'cha go judgin' before you even know it."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Won't you involve me in it <i>somehow?</i>"",
						""mugshot"": ""A_Inquisitive""
					},
					{
						""line"": ""Marisa: Ahahaha...!"",
						""mugshot"": ""M_Exasperated""
					}
				],
				""pointMade"": 10
			}
		},
		{
			""topic"": ""Evil Scheme Confession"",
			""realTalk"": {
				""lines"": [
					{
						""line"": ""Marisa: Okay, you win alright? I'll tell you my evil scheme."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: I'll be needin' your cooperation, so ya better listen carefully."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: J-Just <i>what</i> are you getting at?"",
						""mugshot"": ""A_Side""
					},
					{
						""line"": ""Marisa: The evil scheme is to hold that hand over there. (Points)"",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Alice: <i>W-W-What?</i>"",
						""mugshot"": ""A_Dokidoki""
					},
					{
						""line"": ""Alice: Marisa, y-you're too bold for your own good."",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Alice: (Joins hands with Marisa)"",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Marisa: Nyeheheh..."",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Alice: W-Well?"",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Alice: Isn't there a trick behind this?"",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Marisa: No way. Geez, not everything I do has to be ironic."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Marisa: But you wouldn't 've agreed to this if you didn't take me seriously just this once."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: You're just lucky you didn't misjudge my feelings."",
						""mugshot"": ""A_Side""
					},
					{
						""line"": ""Marisa: Who do think I am? (Aww <i>yes!!</i>)"",
						""mugshot"": ""M_Exasperated""
					}
				]
			},
			""leadInRealTalk"": ""Evil Scheme""
		},
		{
			""topic"": ""Subterranean Animism"",
			""casualTalk"": {
				""alicesOpening"": {
					""line"": ""Alice: Now, what's the next strange place that you'll bring this discussion into?"",
					""mugshot"": ""A_Inquisitive""
				},
				""lines"": [
					{
						""line"": ""Marisa: It's been a while since that geyser incident, huh?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Yes, but it hasn't been a while since you last brought up topics at random."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: Don' 'cha go <i>blamin'</i> me for it."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Marisa: If only there's a bunch'a more things to talk to ya about."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Alice: No one ever told you to team up with me just two times in history."",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: (Frown)"",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Marisa: Ya know, I just realized."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: That geyser incident was one of the few times I borrowed somethin' from you."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Congratulations on returning my dolls in one piece."",
						""mugshot"": ""A_Drama""
					},
					{
						""line"": ""Alice: If you hadn't done so, you wouldn't be here talking to me."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: I really ought'a borrow more things from ya."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: What do you call a life if it isn't lived dangerously?"",
						""mugshot"": ""M_Exasperated""
					}
				],
				""pointMade"": 10
			}
		},
		{
			""topic"": ""Dolls"",
			""casualTalk"": {
				""alicesOpening"": {
					""line"": ""Alice: I still can't get over you calling my dolls a 'bunch'a robots.'"",
					""mugshot"": ""A_Inquisitive""
				},
				""lines"": [
					{
						""line"": ""Marisa: Did ya make your dolls into robots yet?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Fully-autonomous doesn't mean robot, you <i>dummy!</i>"",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: Alright, point taken."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Marisa: You do take a lotta pride in your doll autonomy research."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Alice: You should look forward to the end product. My doll would be very happy to meet you."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Alice: Just so you know, I don't infuse my dolls with ghosts or spirits, because, I'm not a cheater."",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: This is gonna be a treat. Seeing this all the way to the end."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Marisa: ...Ever thought about what'cha gonna do <i>after</i> you finish your doll research?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: No, I have not. When you become engrossed in something, everything else is just a distraction."",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: Can't really screw up on something so precious to you."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Are you trying to jinx it?"",
						""mugshot"": ""A_Inquisitive""
					},
					{
						""line"": ""Marisa: Hurk!"",
						""mugshot"": ""M_Exasperated""
					}
				],
				""pointMade"": 7
			}
		},
		{
			""topic"": ""Borrowing Confession"",
			""realTalk"": {
				""lines"": [
					{
						""line"": ""Marisa: The thing I wanna borrow is your heart, Alice."",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: <i>W-W-What?</i>"",
						""mugshot"": ""A_Dokidoki""
					},
					{
						""line"": ""Marisa: Y-Yeah. Was that too sudden?"",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: Geez, c-can't you be more blunt about it?"",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Marisa: I'm not the kind that sits around waitin' all day."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: So you're mean it's only a recent thing."",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Alice: That's funny... For me, it's goes back very far."",
						""mugshot"": ""A_Flustered""
					},
					{
						""line"": ""Marisa: Oh? ...Sorry for not catchin' on back then."",
						""mugshot"": ""M_Sad""
					},
					{
						""line"": ""Alice: You're really dim-witted, you know that?"",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: Nyehehe..."",
						""mugshot"": ""M_Grin""
					}
				]
			},
			""leadInRealTalk"": ""Borrowing""
		},
		{
			""topic"": ""Confess Fail"",
			""casualTalk"": {
				""lines"": [
					{
						""line"": ""Marisa: Hey, wanna go out with me?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: (Sigh)"",
						""mugshot"": ""A_Sad""
					},
					{
						""line"": ""Alice: Don't you <i>ever</i> get tired of your pranks?"",
						""mugshot"": ""A_Sad""
					},
					{
						""line"": ""Marisa: Wait, I'm being serious, I swear!"",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Alice: ..."",
						""mugshot"": ""A_Inquisitive""
					}
				]
			}
		},
		{
			""topic"": ""The Weather"",
			""casualTalk"": {
				""alicesOpening"": {
					""line"": ""Alice: (Notices Marisa staring at the sky)"",
					""mugshot"": ""A_Inquisitive""
				},
				""lines"": [
					{
						""line"": ""Marisa: Sure is nice out huh?"",
						""mugshot"": ""M_Grin""
					},
					{
						""line"": ""Alice: ..."",
						""mugshot"": ""A_Inquisitive""
					},
					{
						""line"": ""Marisa: I sure wish it comes down hard soon."",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: It will in about 8 hours. And it will drop 4 degrees in the meantime."",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Alice: Predicting the weather is only the most basic of the basics for a magician."",
						""mugshot"": ""A_Lecturing""
					},
					{
						""line"": ""Marisa: I haven't been slacking, I swear!"",
						""mugshot"": ""M_Exasperated""
					},
					{
						""line"": ""Marisa: Anyway, it wouldn't make sense to make small talk about the weather huh?"",
						""mugshot"": ""M_Happy""
					},
					{
						""line"": ""Alice: Yes. You're not making any sense right now."",
						""mugshot"": ""A_Happy""
					},
					{
						""line"": ""Marisa: L-Let's move on."",
						""mugshot"": ""M_Exasperated""
					}
				],
				""pointMade"": 6
			}
		}
	]
}";
}
