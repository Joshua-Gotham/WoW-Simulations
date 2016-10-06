In 7.0, Blizzard introduced the Outlaw specialization to rogues, removing Combat. The new Outlaw spec uses an interesting ability called Roll the Bones, for which this little simulator was created. 

Roll the Bones rolls 6 dice at random, and the rogue receives a buff based on which result appeared the most. I.e. if you rolled all 3s, you'd get the third buff, or if you rolled { 1, 2, 3, 4, 4, 5 }, you'd receive the fourth buff. In the case of a tie you receive all buffs that tied. So if you rolled all unique results, you'd get all 6 buffs. This, naturally, means you can receive 1, 2, 3, or 6 buffs. This simulator determines the odds of each outcome, which helps the player in deciding whether or not re-rolling is worthwhile. 

For example, the odds of rolling 3 buffs is only slightly higher than rolling 6, so you'd never reroll a triple. Whereas 2 buffs is around 35%, so it's worth re-rolling a bad single buff. 

Results(5,000,000 iterations)
One Buff: 59.22%
Two Buffs: 35.38%
Three Buffs: 3.86%
All Buffs: 1.54%
