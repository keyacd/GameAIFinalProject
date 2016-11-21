public List<int> ChainPower = [0, 0, 8, 16, 32, 64, 96, 128, 160, 192, 224, 256, 288, 320, 352, 384, 416, 448, 480, 512, 544, 576, 608, 640, 672];
public int ChainPowerMax = len(ChainPower) - 1;
public List<int> ColorBonus = [0, 0, 3, 6, 12, 24, 48];
public int ColorBonusMax = len(ColorBonus) - 1;
public List<int> GroupBonus = [0, 0, 0, 0, 0, 2, 3, 4, 5, 6, 7, 10];
public int GroupBonusMax = len(GroupBonus) - 1;

public int Score(List<Group> chain) {
	int chainpower = len(chain);
	if (chainpower > ChainPowerMax) { chainpower = ChainPowerMax; }
	chainpower = ChainPower[chainpower];

	List<int> colors = [];
	int groupbonus = 0;
	int puyocleared = 0;
	int c;
	int n;
	for g in chain {
		c = g.GetColor();
		if (not c in colors) { colors.append(color); }
		n = g.Size();
		puyocleared += n;
		if (n > GroupBonusMax) { n = GroupBonusMax; }
		groupbonus += GroupBonus[n];
	}
	int colorbonus = len(colors);
	if (colorbonus > ColorBonusMax) { colorbonus = ColorBonusMax; }
	colorbonus = ColorBonus[colorbonus];

	int score = chainpower + colorbonus + groupbonus;
	if (score > 999) { score = 999; }
	else if (score < 1) { score = 1; }

	score = (10 * chainpower) * score;
	return score;
}
