# BBmanager
Console footbrawl manager game

Skill Db, one skill-player pair per row. SkillId, PlayerID
SkillListDb, every skill in the game
PlayerDb, all the players in the league, TeamId to reach its team, PositionalId to reach its Positional
TeamDb all the teams in the league
AllPositionalsDb, every positional in the game

    Player1.Skills = AllSkills.Where(s => 
                         SkillsDb.GroupBy(p => p.PlayerId)
                        .First(g => g.Key == Player1.Id)
                        .Select(sp => sp.SkillId)
                        .Contains(s.Id)
                        )
                        .ToArray();
                        
                        Blir detta för nästlat? Kanske mer safe att hämta ut spelarens grupp från SkillsDb först och bara köra .Contains på den
                        i AllSkills.Where(...)
