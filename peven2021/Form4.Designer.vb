<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(60, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type de réservation :"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.RadioButton4.Location = New System.Drawing.Point(45, 111)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(171, 35)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Aller simple"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.Location = New System.Drawing.Point(45, 69)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(171, 35)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Aller-retour"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(663, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 222)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type de classe :"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.Location = New System.Drawing.Point(60, 111)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(177, 35)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Economique"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.Location = New System.Drawing.Point(60, 69)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(228, 35)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Homme d'affaire"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(704, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date de retour :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(704, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date d'aller :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(54, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Aéoreport d'arrivée :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(54, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Aéoreport de départ :"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox3.DropDownHeight = 145
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IntegralHeight = False
        Me.ComboBox3.Items.AddRange(New Object() {"Afghanistan Kabul", "Alaska Anchorage Intl", "Alaska Elmendorf", "Alaska Cold Bay", "Alaska Fairbanks Intl", "Alaska Sheyma", "Albania Rinas", "Algeria Touat", "Algeria Houari Boumedienne", "Algeria El Mellah", "Algeria Ain-El-Bey", "Algeria El Golea", "Algeria Ghardaia", "Algeria Oued Irara", "Algeria In Salah", "Algeria Es Senia", "Algeria Tamanrasset", "Algeria In Amenas", "Angola Luanda", "Argentina Ezeiza", "Argentina Comodoro Rivadavia", "Argentina Cordoba", "Argentina Mar De Plata", "Ascension Is. Wideawake", "Australia Adelaide Intl.", "Australia Alice Springs", "Australia Avalon", "Australia Brisbane", "Australia Cairns", "Australia Canberra", "Australia Coolangatta", "Australia Darwin Intl.", "Australia Dampier", "Australia Tindal", "Australia Meekatharra", "Australia Melbourne Intl.", "Australia Mount Isa", "Australia Norfolk Island", "Australia Pearce", "Australia Perth Intl.", "Australia Port Hedland", "Australia Rockhampton", "Australia Kingford Smith", "Australia Townsville", "Austria Innsbruck", "Austria Klagenfurt", "Austria Linz", "Austria Salzburg", "Austria Schwechat", "Azerbaijan Bina", "Azores Lajes", "Azores Ponta Delgardo", "Azores Santa Maria", "Bahamas Freeport", "Bahamas Nassau Intl", "Bahrain Bahrain Intl", "Bangladesh Chittagong", "Bangladesh Tezgaon", "Bangladesh Zia Intl.", "Barbados Grantly Adams Intl", "Belarus Minsk-2", "Belgium Deurne", "Belgium Brussels National", "Belgium Brussels South", "Belgium Bierset", "Belgium Ostend", "Belize Phillip S.W. Goldson Intl", "Benin Cadjehoun", "Bermuda Bermuda", "Botswana Francistown", "Botswana Notwane", "Botswana Seretse Khama Intl.", "Botswana Ghanzi", "Botswana Selebi-Phikwe", "Brazil Trancredo Neves", "Brazil Brasilia", "Brazil Viracopos", "Brazil Fernando De Norohna", "Brazil Hercilio Luz", "Brazil Palmares", "Brazil Augusto Severo", "Brazil Salgado Filho", "Brazil Guararapes", "Brazil Galeao Intl", "Brazil Dois De Julho", "Brazil Sao Jose Dos Campos", "Brazil Guarulhas", "Bulgaria Burgas", "Bulgaria Sofia", "Bulgaria Varna", "Burkina Bobo-Dioulasso", "Burkina Ouagadougou", "Burundi Bujumbura", "Cambodia Pochentong", "Cameroon Douala", "Cameroon Garoua", "Cameroon Nsimalen", "Canada Abbotsford", "Canada Bagotville", "Canada Calgary Intl", "Canada Churchill", "Canada Edmonton Intl", "Canada Fredericton", "Canada Gander", "Canada Goose", "Canada Halifax Intl", "Canada Shearwater", "Canada Hamilton", "Canada Iqualuit", "Canada Kuujjuag", "Canada Moncton", "Canada Mont Joli", "Canada Dorval", "Canada Mirabel", "Canada North Bay", "Canada Ottawa", "Canada Quebec", "Canada Regina", "Canada Sasskatoon", "Canada Sept Iles", "Canada St. Johns", "Canada Stephenville", "Canada Sydney", "Canada Thompson", "Canada Toronto", "Canada Uranium City", "Canada Val D'Or", "Canada Vancouver", "Canada Whitehouse", "Canada Windsor", "Canada Winnipeg", "Canada Yarmouth", "Canada Yellowknife", "Canary Is. Fuerteventura", "Canary Is. Las Palmas", "Canary Is. La Palma", "Canary Is. Lanzarote", "Canary Is. Norte", "Canary Is. Reina Sofia", "Cape Verde Republic Amilcar Cabrai", "Cayman Islands Owen Roberts", "Central African Republic M'Poko", "Chile Carriel Sur", "Chile Pres. Ibanez", "Chile A M Benitez", "China Capital", "China Shuangliu", "China Baiyun", "China Wujiaba", "China Zhongchuan", "China Hongqiac", "China Huangtian", "China Wusu", "China Zhangguizhuang", "China Diwopu", "China Xianyang", "Colombia Cortissoz", "Colombia Eldorado", "Colombia Alfonso Bonilla Aragon", "Colombia R. Nunez", "Colombia San Andres", "Comores & Mayotte Islands Pamanzi", "Comores & Mayotte Islands Hahaia", "Comores & Mayotte Islands Iconi", "Congo Maya Maya", "Congo Pointe Noire", "Croatia Dubrovnik", "Croatia Krk", "Croatia Split", "Croatia Zadar", "Croatia Zagreb", "Cuba Ignacio Agramonte", "Cuba Cayo Largo Del Sur", "Cuba Jose Marti Intl", "Cuba Varadero", "Cyprus Larnaca", "Cyprus Paphos Intl", "Czech Republic Ruzyne", "Denmark Aalborg", "Denmark Billund", "Denmark Ronne", "Denmark Kastrup", "Denmark Roskilde", "Denmark Esbjerg", "Denmark Odense", "Denmark Tirstrup", "Djibouti Ambouli", "Dominican Republic Puerto Plata", "Dominican Republic Punta Cana", "Dominican Republic De Las Americas", "Ecuador Simon Bolivar", "Egypt Alexandria", "Egypt Aswan", "Egypt Cairo Intl.", "Egypt Hurghada", "Egypt Luxor", "Egypt Port Said", "Egypt Ras El Nakab", "Egypt Sharm El-Sheikh", "El Salvador El Salvador Intl", "Ethiopia Bole Intl.", "Ethiopia Asmara", "Ethiopia Aba Tenna Dejaznatch Yilma", "Finland Malmi", "Finland Vantaa", "Finland Ivalo", "Finland Mariehamn", "Finland Oulu", "Finland Pori", "Finland Rovaniemi", "Finland Pirkkala", "Finland Turku", "France Abbeville", "France La Garenne", "France Dell'Oro", "France Avrille", "France Mulhouse", "France Poretta", "France Roumaniere", "France Tille", "France Vias", "France Anglet", "France Merignac", "France Guipavas", "France Bretigny-Sur-Orge", "France Carpiquet", "France Lalbenque", "France Calais-Dunkerque", "France St. Catherine", "France Epinoy", "France Mandelieu", "France Salvaza", "France Aix Les Bains", "France Deols", "France Maupertus", "France Aulnat", "France Houssen", "France St. Gatien", "France St. Aubin", "France Longvic", "France Pleurtuit-St. Malo", "France St. Geoirs", "France Le Palyvestre", "France Laleu", "France Lannion", "France Octeville", "France Arnage", "France Paris Plage", "France Lesquin", "France Bellegarde", "France Bron", "France Provence", "France Nancy Lorraine", "France Frejorgues", "France Ploujean", "France Essey", "France Nantes Atlantique", "France Charles-De-Gaulle", "France Le Bourget", "France Orly", "France Pau Pyrenees", "France Bassillac", "France Rivesaltes", "France Cormeilles En Vexin", "France Pluguffan", "France Champagne", "France St. Jacques", "France Marcillac", "France Vallee De Seine", "France Armor", "France Boutheon", "France Montoir", "France St. Yan", "France Entzheim", "France Ossun-Lourdes", "France Blagnac", "France Francazal", "France St. Symphorien", "France Toussus Le Noble", "France Barberey", "France Chabeuil", "Gabon Mvenge", "Gabon Libreville", "Gabon Port Gentil", "Gambia Banjul", "Georgia Novoalekseevka", "Germany Gatow", "Germany Schoenefield", "Germany Tegel", "Germany Templehof", "Germany Braunsweig", "Germany Bremen", "Germany Cologne-Bonn", "Germany Wickede", "Germany Dresden", "Germany Dusseldorf", "Germany Erfurt", "Germany Main", "Germany Friedrichshafen", "Germany Finkenwerder", "Germany Hamburg", "Germany Hannover", "Germany Ingolstadt", "Germany Kassel-Calden", "Germany Holtenau", "Germany Halle", "Germany Blankensee", "Germany Munich", "Germany Munster/Osnabruck", "Germany Nordholz", "Germany Nurnberg", "Germany Oberpfaffenhofen", "Germany Paderborn", "Germany Ensheim", "Germany Stuttgart", "Germany Westerland", "Ghana Kotoka Intl.", "Ghana Kumsai", "Ghana Sunyani", "Ghana Takoradi", "Ghana Tamale", "Gibralter Gibraltar", "Greece Dimokritos", "Greece Andravida", "Greece Araxos", "Greece Central", "Greece Elefsis", "Greece Nikos Kazantzakis", "Greece Ioannina", "Greece Karpathos", "Greece Megas Alexandros", "Greece Kefallinia", "Greece Ioannis Kapodistrias", "Greece Khios", "Greece Limnos", "Greece Mikonos", "Greece Mitilini", "Greece Diagoras", "Greece Maritsa", "Greece Makedonia", "Greece Samos", "Greece Santorini", "Greece Skiathos", "Greece Zakinthos", "Greenland Narsarsuaq", "Greenland Kangerlussuaq", "Guatemala La Aurora", "Guine-Bissau Osvaldo Vieira", "Guinee Gbessia", "Guyana Timehri Intl", "Hawaiian Islands Honolulu Intl.", "Honduras La Mesa", "Hong Kong Kai Tak", "Hungary Ferihegy", "Iceland Akureyi", "Iceland Keflavik", "Iceland Reykjavik", "India Ahmedabad", "India Bangalore", "India Jawaharial Nehru Intl", "India N.S. Chandra Bose Intl.", "India Delhi Intl.", "India Dabolim", "India Begumpet", "India Lucknow", "India Madras Intl.", "India Nagpur", "India Port Blair", "India Trivandrum", "Indonesia Pattimura", "Indonesia Bali Intl.", "Indonesia Kaisiepo", "Indonesia Halim Perdanakusuma", "Indonesia Soerkarno-Hatta Intl.", "Indonesia El Tari", "Indonesia Polonia", "Indonesia Juanda", "Indonesia Hasanuddin", "Iran Shiraz Intl.", "Iran Tabriz", "Iran Mehrabad", "Iraq Saddam Intl.", "Ireland Connaught", "Ireland Cork", "Ireland Carrickfin", "Ireland Dublin", "Ireland Carnmore", "Ireland Farranfore", "Ireland Shannon", "Ireland Waterford", "Israel Atarot", "Israel Ovda", "Israel Ben Gurion Intl.", "Italy Fertillia", "Italy Falconara", "Italy Palese Mcchie", "Italy Orio Al Serio", "Italy Bologna", "Italy Casale", "Italy Elmas", "Italy Fontanarossa", "Italy Peretola", "Italy Forli", "Italy Sestri", "Italy Lamezia Terme", "Italy Linate", "Italy Malpensa", "Italy Naples", "Italy Costa Smeralda", "Italy Punta Raisi", "Italy Parma", "Italy Pescara", "Italy Pisa", "Ivory Coast Port Bouet", "Ivory Coast Yamoussoukro", "Jamaica Kingston", "Jamaica Sangster Intl", "Japan Chitose Aiport [New]", "Japan Fukuoka", "Japan Hakodate", "Japan Iwakuni", "Japan Kagoshima", "Japan Nagasaki", "Japan Nagoya", "Japan Itami", "Japan Kansai Intl.", "Japan Sendai", "Japan Haneda", "Japan Narita", "Japan Yokota", "Kenya Kisumu", "Kenya Malindi", "Kenya Moi", "Kenya Jomo Kenyatta", "Latvia Riga Intl.", "Lesotho Moshoeshoe 1", "Liberia Roberts Intl.", "Liberia Spriggs Payne", "Libya Benina", "Libya Kufra", "Libya Sebha Intl.", "Libya Tripoli Intl.", "Lithunia Vilnius", "Luxembourg Luxembourg", "Madagascar Ivato", "Madagascar Amborovy", "Madagascar Gillot", "Madagascar Toamasina", "Madeira Funchal", "Madeira Porto Santo", "Malawi Chileka", "Malawi Karonga", "Malawi Kamuzu Intl.", "Malawi Mzuzu", "Malaysia & Brunei Sultan Abdul Halim", "Malaysia & Brunei Bandar Seri Begawan", "Malaysia & Brunei Johor Bahru", "Malaysia & Brunei Sultan Ismail Petra", "Malaysia & Brunei Kota Kinbalu", "Malaysia & Brunei Simpang", "Malaysia & Brunei Kuala Lumpur Intl.", "Malaysia & Brunei Labuan", "Malaysia & Brunei Male Intl.", "Malaysia & Brunei Miri", "Malaysia & Brunei Penang Intl.", "Malaysia & Brunei Sibu", "Malaysia & Brunei Tawau", "Mali Senou", "Mali Barbe", "Mali Nioro", "Mali Tombouctou", "Malta Luqa", "Mauritania Nouadhibou", "Mauritania Nouakchott", "Mauritius Plaisance Intl.", "Mexico Acapulco Intl", "Mexico Campeche", "Mexico Cancun", "Mexico Chetumal", "Mexico Cozumel", "Mexico Dom Migel Hidalgo", "Mexico Ixtapa-Zihuatanejo", "Mexico Merida", "Mexico B. Juarez Intl", "Mexico Tampico", "Morocco Al Massirah", "Morocco Cote Du Rif", "Morocco Anfa", "Morocco Mohamed V", "Morocco Hassan Ist", "Morocco Menara", "Morocco Ouarzazate", "Morocco Angad", "Morocco Sale", "Morocco Boukhalf", "Morocco Sania Ramel", "Mozambique Beira", "Mozambique Inhambane", "Mozambique Maputo", "Mozambique Nampula", "Mozambique Chingodzi", "Mozambique Vilankulu", "Nepal Tribhuvan", "Netherlands Schipol", "Netherlands Groningen", "Netherlands Eindhoven", "Netherlands Lelystad", "Netherlands Maastricht", "Netherlands Rotterdam", "New Zealand Auckland Intl.", "New Zealand Christchurch Intl.", "New Zealand Wellington Intl.", "Niger Sud", "Niger Niamey", "Niger Zinder", "Nigeria Calabar", "Nigeria Enugu", "Nigeria Ibadan (New)", "Nigeria Ilorin", "Nigeria Jos", "Nigeria Kaduna (New)", "Nigeria Mallam Aminu Intl.", "Nigeria Murtala Muhammed", "Nigeria Maiduguri", "Nigeria Port Haircourt", "Nigeria Sokoto", "Nigeria Yola", "Norway Vigra", "Norway Flesland", "Norway Floro", "Norway Evenes", "Norway Karmony", "Norway Hoybuktmoen", "Norway Kjevik", "Norway Kvernberget", "Norway Fornebu", "Norway Gardermoen", "Norway Sola", "Norway Torp", "Norway Tromso", "Oman Seeb", "Oman Salalah", "Pakistan Chaklala", "Pakistan Karachi", "Pakistan Lahore", "Pakistan Nawabshah", "Papua New Guinea Jacksons", "Philippines Lapu Lapu", "Philippines Manila Intl.", "Poland Gdansk", "Poland Krakow", "Poland Poznan", "Poland Okecie", "Portugal Faro", "Portugal Lisbon", "Portugal Francisco Sa Carneiro", "Puerto Rico Luis Munoz Marin Intl", "Qatar Doha", "Romania Baneasa", "Romania Otopeni", "Romania Kogainiceanu", "Romania Giarmata", "Russia Novy", "Russia Sheremetievo", "Russia Vnukovo", "Russia Tolmachevo", "Russia Tsentralny", "Russia Kurumoch", "Russia Pulkovo", "Russia Migalovo", "Russia Yakutsk", "Sao Tome & Principe Sao Tome", "Saudi Arabia Abha", "Saudi Arabia Al Jouf", "Saudi Arabia Badanah", "Saudi Arabia Dharan", "Saudi Arabia Gassim", "Saudi Arabia Hafr-Al-Batin", "Saudi Arabia Hail", "Saudi Arabia King Abdulaziz", "Saudi Arabia Madinah", "Saudi Arabia King Khalid Intl.", "Saudi Arabia Taif", "Saudi Arabia Turaif", "Saudi Arabia Wejh", "Senegal Yoff", "Seychelles Seychelles Intl.", "Sierra Leone Lungi", "Singapore Changi", "Singapore Paya Lebar", "Slovak Republic Ivanka", "Slovak Republic Kosice", "Slovak Republic Tatry", "Slovenia Ljubljana", "Slovenia Maribor", "Somalia Republic Kismayu", "Somalia Republic Mogadishu", "South Africa Beaufort West", "South Africa Bethlehem", "South Africa Bisho", "South Africa J.B.M. Herzog", "South Africa D.F. Malan", "South Africa Louis Botha", "South Africa Virginia", "South Africa East London", "South Africa Ficksburg", "South Africa P.W. Botha", "South Africa Giyani", "South Africa Grahamstown", "South Africa Grand Central", "South Africa Grootfontein", "South Africa Heidelberg", "South Africa Heilbron", "South Africa Jan Smuts", "South Africa Rand", "South Africa Keetmanshoop", "South Africa Rwanda", "South Africa B.J. Vorster", "South Africa Kleinsee", "South Africa Komatipoort", "South Africa Kroonstad", "South Africa Ladysmith", "South Africa Lanseria", "South Africa Lichtenburg", "South Africa Luderitz", "South Africa Lydenburg", "South Africa Malelane", "South Africa Margate", "South Africa Messina", "South Africa Mmabatho", "South Africa Nelspruit", "South Africa Newcastle", "South Africa Otjiwarongo", "South Africa Hendrick Van Eck", "South Africa Piet Retief", "South Africa Pietermaritzburg", "South Africa Pietersburg (Civil)", "South Africa Sun City", "South Africa Plettenberg Bay", "South Africa Port Elizabeth", "South Africa Wonderbroom", "South Africa Queenstown", "South Africa Richards Bay", "South Africa Sishen", "South Africa Thaba Nchu", "South Africa Ulundi", "South Africa Pierre Van Ryneveld", "South Africa Vereeniging", "South Africa Victoria West", "South Africa Vryheid", "South Africa Welkom", "South Africa Eros", "South Africa Windhoek Intl.", "South Korea Cheju Intl.", "South Korea Kimhae Intl.", "South Korea Kimpo Intl.", "Spain Alicante", "Spain Almeria", "Spain Asturias", "Spain Barcelona", "Spain Bilbao", "Spain Cordoba", "Spain Gerona", "Spain Granda", "Spain Ibiza", "Spain Jerez", "Spain La Coruna", "Spain Barajas", "Spain Getafe", "Spain Malaga", "Spain Minorca", "Spain Palma", "Spain Pamplona", "Spain Reus", "Spain Salamanca", "Spain San Sebastian", "Spain Santander", "Spain Santiago", "Spain Seville", "Spain Valencia", "Spain Vigo", "Spain Vitoria", "Sri Lanka Katunayake", "Sri Lanka Ratmalana", "Sri Lanka Jaffna", "Sudan Geneina", "Sudan Juba", "Sudan Khartoum", "Swaziland Manzini", "Sweden Angelholm", "Sweden Borlange", "Sweden Save", "Sweden Jonkoping", "Sweden Kalmar", "Sweden Karlstad", "Sweden Sturup", "Sweden Siljan", "Sweden Kungsangen", "Sweden Orebro", "Sweden Arlanda", "Sweden Bromma", "Sweden Harnosand", "Sweden Umea", "Sweden Visby", "Switzerland Belp", "Switzerland Geneva", "Switzerland Sion", "Switzerland Zurich", "Syria Damascus Intl.", "Taiwan Kaohsiung Intl.", "Taiwan Chiang Kai Shek", "Tanzania Dar Es Salaam", "Tanzania Kilimanjaro", "Tanzania Mtwara", "Tanzania Mwanza", "Tanzania Karume", "Tanzania Tabora", "Tanzania Tanga", "Tanzania Kisauni", "Tchad N'Djamena", "Thailand Bangkok", "Thailand Chiang Mai", "Thailand Phuket", "Thailand Hat Yai Intl.", "Thailand Surat Thani", "Togo Tokoin", "Trinidad & Tobago Piarco", "Trinidad & Tobago Crown Point", "Tunisia Zarzis", "Tunisia Habib Bourguiba Intl", "Tunisia Thyna", "Tunisia Nefta", "Tunisia Carthage", "Turkey Sakirpasa", "Turkey Esenboga", "Turkey Mugla", "Turkey Ataturk", "Turkey Adnan Menderes", "Turkmenistan Ashkhabad", "Uganda Entebbe", "Ukraine Borispol", "Ukraine Lvov", "Ukraine Odessa", "United Arab Emirates Abu Dhabi Intl", "United Arab Emirates Bateen", "United Arab Emirates Dubai", "United Arab Emirates Fujairah Intl.", "United Arab Emirates Ras Al Khaimah", "United Arab Emirates Sharjah Intl.", "United Kingdom Aberdeen", "United Kingdom Alderney", "United Kingdom Wideawake", "United Kingdom Walney Island", "United Kingdom Bedford", "United Kingdom Aldergrove", "United Kingdom City", "United Kingdom Bembridge", "United Kingdom Benbecula", "United Kingdom Biggin Hill", "United Kingdom Birmingham", "United Kingdom Blackbushe", "United Kingdom Blackpool", "United Kingdom Bournemouth", "United Kingdom Bristol", "United Kingdom Cambridge", "United Kingdom Cardiff", "United Kingdom Carlisle", "United Kingdom Coventry", "United Kingdom Cranfield", "United Kingdom Dundee", "United Kingdom East Midlands", "United Kingdom Edinburgh", "United Kingdom Exeter", "United Kingdom Glasgow", "United Kingdom Gloucestershire", "United Kingdom Guernsey", "United Kingdom Humberside", "United Kingdom Dalcross", "United Kingdom Islay", "United Kingdom Ronaldsway", "United Kingdom Jersey", "United Kingdom Kirkwall", "United Kingdom Leeds Bradford", "United Kingdom Liverpool", "United Kingdom City", "United Kingdom Gatwick", "United Kingdom Heathrow", "United Kingdom Stansted", "United Kingdom Luton", "United Kingdom Lydd", "United Kingdom Manchester", "United Kingdom Manston", "United Kingdom Newcastle", "United Kingdom Kidlington", "United Kingdom City", "United Kingdom Prestwick", "United Kingdom Eastleigh", "United Kingdom Southend", "United Kingdom Stornoway", "United Kingdom Sumburgh", "United Kingdom Swansea", "United Kingdom Teeside", "United Kingdom Tiree", "United Kingdom Unst", "United Kingdom Wick", "United States Albuquerque", "United States Wm. B. Hartsfield", "United States Atlantic City", "United States Washington Intl", "United States Bangor Intl", "United States Bedford", "United States Birmingham Intl", "United States Logan Intl", "United States Buffalo", "United States Burlington", "United States Natrona County Intl", "United States Sanford", "United States Charleston", "United States Douglas", "United States Lovell Field", "United States Cheyenne", "United States Chicago O'Hare", "United States Northern Kentucky Intl", "United States Clearwater", "United States Cleveland", "United States City Of Colarado", "United States Columbia Met", "United States Port Columbus", "United States Dallas Fort Worth", "United States Love Field", "United States Denver Intl", "United States Des Moines", "United States Wayne", "United States Willow Run", "United States Duluth Intl", "United States Snohomish County", "United States Hector Intl", "United States Fort Lauderdale", "United States Fresno", "United States Walker Field", "United States Great Falls", "United States Houston Intl", "United States Huntsville", "United States Indianapolis Intl", "United States Jacksonville Intl", "United States Kansas City Intl", "United States Knoxville", "United States Las Vegas", "United States Long Beach", "United States Los Angeles Intl", "United States Standiford Field", "United States Memphis Intl", "United States Miami Intl", "United States Milwaukee", "United States Minneapolis", "United States Montgomery", "United States Grant County", "United States Nashville", "United States New Orleans", "United States John F. Kennedy", "United States La Guardia", "United States Newark Intl", "United States Stewart", "United States Williamsburg Intl", "United States Niagara Falls", "United States Norfolk Intl", "United States Oakland", "United States Eppley", "United States Ontario Intl", "United States Orlando", "United States Philadelphia", "United States Sky Harbor", "United States Pittsburgh", "United States Portland Intl", "United States Portland Intl Jetport", "United States Northern Maine Regional", "United States Pueblo Memorial", "United States Cannon Intl", "United States Richmond", "United States Metroplolitan", "United States Salt Lake City", "United States San Antonio Intl", "United States San Diego", "United States San Francisco", "United States Savannah", "United States Tacoma", "United States King County Intl", "United States Sioux Falls", "United States Spokane Intl", "United States St. Louis Intl", "United States Hancock Intl", "United States Tampa Intl", "United States Dulles", "United States National", "United States West Palm Beach", "United States New Hanover County", "United States Windsor Locks", "Uruguay Carrasco", "Uzbekistan Samarkand", "Uzbekistan Yuzhnyy", "Venezuela Simon Bolivar", "Venezuela La Chinita", "Venezuela Del Caribe", "Vietnam Danang", "Vietnam Noibai", "Vietnam Tansonnhat", "Windward Islands Hewanorra Intl", "Yemen Arab Republic Aden", "Yemen Arab Republic Hodeidah", "Yemen Arab Republic Sanaa Intl.", "Yemen Arab Republic Ganed", "Yugoslavia Belgrade", "Yugoslavia Mostar", "Yugoslavia Ohrid", "Yugoslavia Podgorica", "Yugoslavia Sarajevo", "Yugoslavia Skopje", "Yugoslavia Tivat", "Zaire Ndjili", "Zaire Bangoka", "Zaire Barrer Luano", "Zaire Mbuji-Mayi", "Zambia Kasama", "Zambia Livingstone", "Zambia Lusaka Intl.", "Zambia Mansa", "Zambia Mongu", "Zambia N'Dola", "Zimbabwae Bulawayo", "Zimbabwae Buffalo Range", "Zimbabwae Charles Prince", "Zimbabwae Harare Intl.", "Zimbabwae National Park", "Zimbabwae Kariba", "Zimbabwae Masvingo", "Zimbabwae Victoria Falls"})
        Me.ComboBox3.Location = New System.Drawing.Point(336, 480)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(286, 26)
        Me.ComboBox3.TabIndex = 7
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox4.DropDownHeight = 145
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.IntegralHeight = False
        Me.ComboBox4.ItemHeight = 18
        Me.ComboBox4.Items.AddRange(New Object() {"Afghanistan Kabul", "Alaska Anchorage Intl", "Alaska Elmendorf", "Alaska Cold Bay", "Alaska Fairbanks Intl", "Alaska Sheyma", "Albania Rinas", "Algeria Touat", "Algeria Houari Boumedienne", "Algeria El Mellah", "Algeria Ain-El-Bey", "Algeria El Golea", "Algeria Ghardaia", "Algeria Oued Irara", "Algeria In Salah", "Algeria Es Senia", "Algeria Tamanrasset", "Algeria In Amenas", "Angola Luanda", "Argentina Ezeiza", "Argentina Comodoro Rivadavia", "Argentina Cordoba", "Argentina Mar De Plata", "Ascension Is. Wideawake", "Australia Adelaide Intl.", "Australia Alice Springs", "Australia Avalon", "Australia Brisbane", "Australia Cairns", "Australia Canberra", "Australia Coolangatta", "Australia Darwin Intl.", "Australia Dampier", "Australia Tindal", "Australia Meekatharra", "Australia Melbourne Intl.", "Australia Mount Isa", "Australia Norfolk Island", "Australia Pearce", "Australia Perth Intl.", "Australia Port Hedland", "Australia Rockhampton", "Australia Kingford Smith", "Australia Townsville", "Austria Innsbruck", "Austria Klagenfurt", "Austria Linz", "Austria Salzburg", "Austria Schwechat", "Azerbaijan Bina", "Azores Lajes", "Azores Ponta Delgardo", "Azores Santa Maria", "Bahamas Freeport", "Bahamas Nassau Intl", "Bahrain Bahrain Intl", "Bangladesh Chittagong", "Bangladesh Tezgaon", "Bangladesh Zia Intl.", "Barbados Grantly Adams Intl", "Belarus Minsk-2", "Belgium Deurne", "Belgium Brussels National", "Belgium Brussels South", "Belgium Bierset", "Belgium Ostend", "Belize Phillip S.W. Goldson Intl", "Benin Cadjehoun", "Bermuda Bermuda", "Botswana Francistown", "Botswana Notwane", "Botswana Seretse Khama Intl.", "Botswana Ghanzi", "Botswana Selebi-Phikwe", "Brazil Trancredo Neves", "Brazil Brasilia", "Brazil Viracopos", "Brazil Fernando De Norohna", "Brazil Hercilio Luz", "Brazil Palmares", "Brazil Augusto Severo", "Brazil Salgado Filho", "Brazil Guararapes", "Brazil Galeao Intl", "Brazil Dois De Julho", "Brazil Sao Jose Dos Campos", "Brazil Guarulhas", "Bulgaria Burgas", "Bulgaria Sofia", "Bulgaria Varna", "Burkina Bobo-Dioulasso", "Burkina Ouagadougou", "Burundi Bujumbura", "Cambodia Pochentong", "Cameroon Douala", "Cameroon Garoua", "Cameroon Nsimalen", "Canada Abbotsford", "Canada Bagotville", "Canada Calgary Intl", "Canada Churchill", "Canada Edmonton Intl", "Canada Fredericton", "Canada Gander", "Canada Goose", "Canada Halifax Intl", "Canada Shearwater", "Canada Hamilton", "Canada Iqualuit", "Canada Kuujjuag", "Canada Moncton", "Canada Mont Joli", "Canada Dorval", "Canada Mirabel", "Canada North Bay", "Canada Ottawa", "Canada Quebec", "Canada Regina", "Canada Sasskatoon", "Canada Sept Iles", "Canada St. Johns", "Canada Stephenville", "Canada Sydney", "Canada Thompson", "Canada Toronto", "Canada Uranium City", "Canada Val D'Or", "Canada Vancouver", "Canada Whitehouse", "Canada Windsor", "Canada Winnipeg", "Canada Yarmouth", "Canada Yellowknife", "Canary Is. Fuerteventura", "Canary Is. Las Palmas", "Canary Is. La Palma", "Canary Is. Lanzarote", "Canary Is. Norte", "Canary Is. Reina Sofia", "Cape Verde Republic Amilcar Cabrai", "Cayman Islands Owen Roberts", "Central African Republic M'Poko", "Chile Carriel Sur", "Chile Pres. Ibanez", "Chile A M Benitez", "China Capital", "China Shuangliu", "China Baiyun", "China Wujiaba", "China Zhongchuan", "China Hongqiac", "China Huangtian", "China Wusu", "China Zhangguizhuang", "China Diwopu", "China Xianyang", "Colombia Cortissoz", "Colombia Eldorado", "Colombia Alfonso Bonilla Aragon", "Colombia R. Nunez", "Colombia San Andres", "Comores & Mayotte Islands Pamanzi", "Comores & Mayotte Islands Hahaia", "Comores & Mayotte Islands Iconi", "Congo Maya Maya", "Congo Pointe Noire", "Croatia Dubrovnik", "Croatia Krk", "Croatia Split", "Croatia Zadar", "Croatia Zagreb", "Cuba Ignacio Agramonte", "Cuba Cayo Largo Del Sur", "Cuba Jose Marti Intl", "Cuba Varadero", "Cyprus Larnaca", "Cyprus Paphos Intl", "Czech Republic Ruzyne", "Denmark Aalborg", "Denmark Billund", "Denmark Ronne", "Denmark Kastrup", "Denmark Roskilde", "Denmark Esbjerg", "Denmark Odense", "Denmark Tirstrup", "Djibouti Ambouli", "Dominican Republic Puerto Plata", "Dominican Republic Punta Cana", "Dominican Republic De Las Americas", "Ecuador Simon Bolivar", "Egypt Alexandria", "Egypt Aswan", "Egypt Cairo Intl.", "Egypt Hurghada", "Egypt Luxor", "Egypt Port Said", "Egypt Ras El Nakab", "Egypt Sharm El-Sheikh", "El Salvador El Salvador Intl", "Ethiopia Bole Intl.", "Ethiopia Asmara", "Ethiopia Aba Tenna Dejaznatch Yilma", "Finland Malmi", "Finland Vantaa", "Finland Ivalo", "Finland Mariehamn", "Finland Oulu", "Finland Pori", "Finland Rovaniemi", "Finland Pirkkala", "Finland Turku", "France Abbeville", "France La Garenne", "France Dell'Oro", "France Avrille", "France Mulhouse", "France Poretta", "France Roumaniere", "France Tille", "France Vias", "France Anglet", "France Merignac", "France Guipavas", "France Bretigny-Sur-Orge", "France Carpiquet", "France Lalbenque", "France Calais-Dunkerque", "France St. Catherine", "France Epinoy", "France Mandelieu", "France Salvaza", "France Aix Les Bains", "France Deols", "France Maupertus", "France Aulnat", "France Houssen", "France St. Gatien", "France St. Aubin", "France Longvic", "France Pleurtuit-St. Malo", "France St. Geoirs", "France Le Palyvestre", "France Laleu", "France Lannion", "France Octeville", "France Arnage", "France Paris Plage", "France Lesquin", "France Bellegarde", "France Bron", "France Provence", "France Nancy Lorraine", "France Frejorgues", "France Ploujean", "France Essey", "France Nantes Atlantique", "France Charles-De-Gaulle", "France Le Bourget", "France Orly", "France Pau Pyrenees", "France Bassillac", "France Rivesaltes", "France Cormeilles En Vexin", "France Pluguffan", "France Champagne", "France St. Jacques", "France Marcillac", "France Vallee De Seine", "France Armor", "France Boutheon", "France Montoir", "France St. Yan", "France Entzheim", "France Ossun-Lourdes", "France Blagnac", "France Francazal", "France St. Symphorien", "France Toussus Le Noble", "France Barberey", "France Chabeuil", "Gabon Mvenge", "Gabon Libreville", "Gabon Port Gentil", "Gambia Banjul", "Georgia Novoalekseevka", "Germany Gatow", "Germany Schoenefield", "Germany Tegel", "Germany Templehof", "Germany Braunsweig", "Germany Bremen", "Germany Cologne-Bonn", "Germany Wickede", "Germany Dresden", "Germany Dusseldorf", "Germany Erfurt", "Germany Main", "Germany Friedrichshafen", "Germany Finkenwerder", "Germany Hamburg", "Germany Hannover", "Germany Ingolstadt", "Germany Kassel-Calden", "Germany Holtenau", "Germany Halle", "Germany Blankensee", "Germany Munich", "Germany Munster/Osnabruck", "Germany Nordholz", "Germany Nurnberg", "Germany Oberpfaffenhofen", "Germany Paderborn", "Germany Ensheim", "Germany Stuttgart", "Germany Westerland", "Ghana Kotoka Intl.", "Ghana Kumsai", "Ghana Sunyani", "Ghana Takoradi", "Ghana Tamale", "Gibralter Gibraltar", "Greece Dimokritos", "Greece Andravida", "Greece Araxos", "Greece Central", "Greece Elefsis", "Greece Nikos Kazantzakis", "Greece Ioannina", "Greece Karpathos", "Greece Megas Alexandros", "Greece Kefallinia", "Greece Ioannis Kapodistrias", "Greece Khios", "Greece Limnos", "Greece Mikonos", "Greece Mitilini", "Greece Diagoras", "Greece Maritsa", "Greece Makedonia", "Greece Samos", "Greece Santorini", "Greece Skiathos", "Greece Zakinthos", "Greenland Narsarsuaq", "Greenland Kangerlussuaq", "Guatemala La Aurora", "Guine-Bissau Osvaldo Vieira", "Guinee Gbessia", "Guyana Timehri Intl", "Hawaiian Islands Honolulu Intl.", "Honduras La Mesa", "Hong Kong Kai Tak", "Hungary Ferihegy", "Iceland Akureyi", "Iceland Keflavik", "Iceland Reykjavik", "India Ahmedabad", "India Bangalore", "India Jawaharial Nehru Intl", "India N.S. Chandra Bose Intl.", "India Delhi Intl.", "India Dabolim", "India Begumpet", "India Lucknow", "India Madras Intl.", "India Nagpur", "India Port Blair", "India Trivandrum", "Indonesia Pattimura", "Indonesia Bali Intl.", "Indonesia Kaisiepo", "Indonesia Halim Perdanakusuma", "Indonesia Soerkarno-Hatta Intl.", "Indonesia El Tari", "Indonesia Polonia", "Indonesia Juanda", "Indonesia Hasanuddin", "Iran Shiraz Intl.", "Iran Tabriz", "Iran Mehrabad", "Iraq Saddam Intl.", "Ireland Connaught", "Ireland Cork", "Ireland Carrickfin", "Ireland Dublin", "Ireland Carnmore", "Ireland Farranfore", "Ireland Shannon", "Ireland Waterford", "Israel Atarot", "Israel Ovda", "Israel Ben Gurion Intl.", "Italy Fertillia", "Italy Falconara", "Italy Palese Mcchie", "Italy Orio Al Serio", "Italy Bologna", "Italy Casale", "Italy Elmas", "Italy Fontanarossa", "Italy Peretola", "Italy Forli", "Italy Sestri", "Italy Lamezia Terme", "Italy Linate", "Italy Malpensa", "Italy Naples", "Italy Costa Smeralda", "Italy Punta Raisi", "Italy Parma", "Italy Pescara", "Italy Pisa", "Ivory Coast Port Bouet", "Ivory Coast Yamoussoukro", "Jamaica Kingston", "Jamaica Sangster Intl", "Japan Chitose Aiport [New]", "Japan Fukuoka", "Japan Hakodate", "Japan Iwakuni", "Japan Kagoshima", "Japan Nagasaki", "Japan Nagoya", "Japan Itami", "Japan Kansai Intl.", "Japan Sendai", "Japan Haneda", "Japan Narita", "Japan Yokota", "Kenya Kisumu", "Kenya Malindi", "Kenya Moi", "Kenya Jomo Kenyatta", "Latvia Riga Intl.", "Lesotho Moshoeshoe 1", "Liberia Roberts Intl.", "Liberia Spriggs Payne", "Libya Benina", "Libya Kufra", "Libya Sebha Intl.", "Libya Tripoli Intl.", "Lithunia Vilnius", "Luxembourg Luxembourg", "Madagascar Ivato", "Madagascar Amborovy", "Madagascar Gillot", "Madagascar Toamasina", "Madeira Funchal", "Madeira Porto Santo", "Malawi Chileka", "Malawi Karonga", "Malawi Kamuzu Intl.", "Malawi Mzuzu", "Malaysia & Brunei Sultan Abdul Halim", "Malaysia & Brunei Bandar Seri Begawan", "Malaysia & Brunei Johor Bahru", "Malaysia & Brunei Sultan Ismail Petra", "Malaysia & Brunei Kota Kinbalu", "Malaysia & Brunei Simpang", "Malaysia & Brunei Kuala Lumpur Intl.", "Malaysia & Brunei Labuan", "Malaysia & Brunei Male Intl.", "Malaysia & Brunei Miri", "Malaysia & Brunei Penang Intl.", "Malaysia & Brunei Sibu", "Malaysia & Brunei Tawau", "Mali Senou", "Mali Barbe", "Mali Nioro", "Mali Tombouctou", "Malta Luqa", "Mauritania Nouadhibou", "Mauritania Nouakchott", "Mauritius Plaisance Intl.", "Mexico Acapulco Intl", "Mexico Campeche", "Mexico Cancun", "Mexico Chetumal", "Mexico Cozumel", "Mexico Dom Migel Hidalgo", "Mexico Ixtapa-Zihuatanejo", "Mexico Merida", "Mexico B. Juarez Intl", "Mexico Tampico", "Morocco Al Massirah", "Morocco Cote Du Rif", "Morocco Anfa", "Morocco Mohamed V", "Morocco Hassan Ist", "Morocco Menara", "Morocco Ouarzazate", "Morocco Angad", "Morocco Sale", "Morocco Boukhalf", "Morocco Sania Ramel", "Mozambique Beira", "Mozambique Inhambane", "Mozambique Maputo", "Mozambique Nampula", "Mozambique Chingodzi", "Mozambique Vilankulu", "Nepal Tribhuvan", "Netherlands Schipol", "Netherlands Groningen", "Netherlands Eindhoven", "Netherlands Lelystad", "Netherlands Maastricht", "Netherlands Rotterdam", "New Zealand Auckland Intl.", "New Zealand Christchurch Intl.", "New Zealand Wellington Intl.", "Niger Sud", "Niger Niamey", "Niger Zinder", "Nigeria Calabar", "Nigeria Enugu", "Nigeria Ibadan (New)", "Nigeria Ilorin", "Nigeria Jos", "Nigeria Kaduna (New)", "Nigeria Mallam Aminu Intl.", "Nigeria Murtala Muhammed", "Nigeria Maiduguri", "Nigeria Port Haircourt", "Nigeria Sokoto", "Nigeria Yola", "Norway Vigra", "Norway Flesland", "Norway Floro", "Norway Evenes", "Norway Karmony", "Norway Hoybuktmoen", "Norway Kjevik", "Norway Kvernberget", "Norway Fornebu", "Norway Gardermoen", "Norway Sola", "Norway Torp", "Norway Tromso", "Oman Seeb", "Oman Salalah", "Pakistan Chaklala", "Pakistan Karachi", "Pakistan Lahore", "Pakistan Nawabshah", "Papua New Guinea Jacksons", "Philippines Lapu Lapu", "Philippines Manila Intl.", "Poland Gdansk", "Poland Krakow", "Poland Poznan", "Poland Okecie", "Portugal Faro", "Portugal Lisbon", "Portugal Francisco Sa Carneiro", "Puerto Rico Luis Munoz Marin Intl", "Qatar Doha", "Romania Baneasa", "Romania Otopeni", "Romania Kogainiceanu", "Romania Giarmata", "Russia Novy", "Russia Sheremetievo", "Russia Vnukovo", "Russia Tolmachevo", "Russia Tsentralny", "Russia Kurumoch", "Russia Pulkovo", "Russia Migalovo", "Russia Yakutsk", "Sao Tome & Principe Sao Tome", "Saudi Arabia Abha", "Saudi Arabia Al Jouf", "Saudi Arabia Badanah", "Saudi Arabia Dharan", "Saudi Arabia Gassim", "Saudi Arabia Hafr-Al-Batin", "Saudi Arabia Hail", "Saudi Arabia King Abdulaziz", "Saudi Arabia Madinah", "Saudi Arabia King Khalid Intl.", "Saudi Arabia Taif", "Saudi Arabia Turaif", "Saudi Arabia Wejh", "Senegal Yoff", "Seychelles Seychelles Intl.", "Sierra Leone Lungi", "Singapore Changi", "Singapore Paya Lebar", "Slovak Republic Ivanka", "Slovak Republic Kosice", "Slovak Republic Tatry", "Slovenia Ljubljana", "Slovenia Maribor", "Somalia Republic Kismayu", "Somalia Republic Mogadishu", "South Africa Beaufort West", "South Africa Bethlehem", "South Africa Bisho", "South Africa J.B.M. Herzog", "South Africa D.F. Malan", "South Africa Louis Botha", "South Africa Virginia", "South Africa East London", "South Africa Ficksburg", "South Africa P.W. Botha", "South Africa Giyani", "South Africa Grahamstown", "South Africa Grand Central", "South Africa Grootfontein", "South Africa Heidelberg", "South Africa Heilbron", "South Africa Jan Smuts", "South Africa Rand", "South Africa Keetmanshoop", "South Africa Rwanda", "South Africa B.J. Vorster", "South Africa Kleinsee", "South Africa Komatipoort", "South Africa Kroonstad", "South Africa Ladysmith", "South Africa Lanseria", "South Africa Lichtenburg", "South Africa Luderitz", "South Africa Lydenburg", "South Africa Malelane", "South Africa Margate", "South Africa Messina", "South Africa Mmabatho", "South Africa Nelspruit", "South Africa Newcastle", "South Africa Otjiwarongo", "South Africa Hendrick Van Eck", "South Africa Piet Retief", "South Africa Pietermaritzburg", "South Africa Pietersburg (Civil)", "South Africa Sun City", "South Africa Plettenberg Bay", "South Africa Port Elizabeth", "South Africa Wonderbroom", "South Africa Queenstown", "South Africa Richards Bay", "South Africa Sishen", "South Africa Thaba Nchu", "South Africa Ulundi", "South Africa Pierre Van Ryneveld", "South Africa Vereeniging", "South Africa Victoria West", "South Africa Vryheid", "South Africa Welkom", "South Africa Eros", "South Africa Windhoek Intl.", "South Korea Cheju Intl.", "South Korea Kimhae Intl.", "South Korea Kimpo Intl.", "Spain Alicante", "Spain Almeria", "Spain Asturias", "Spain Barcelona", "Spain Bilbao", "Spain Cordoba", "Spain Gerona", "Spain Granda", "Spain Ibiza", "Spain Jerez", "Spain La Coruna", "Spain Barajas", "Spain Getafe", "Spain Malaga", "Spain Minorca", "Spain Palma", "Spain Pamplona", "Spain Reus", "Spain Salamanca", "Spain San Sebastian", "Spain Santander", "Spain Santiago", "Spain Seville", "Spain Valencia", "Spain Vigo", "Spain Vitoria", "Sri Lanka Katunayake", "Sri Lanka Ratmalana", "Sri Lanka Jaffna", "Sudan Geneina", "Sudan Juba", "Sudan Khartoum", "Swaziland Manzini", "Sweden Angelholm", "Sweden Borlange", "Sweden Save", "Sweden Jonkoping", "Sweden Kalmar", "Sweden Karlstad", "Sweden Sturup", "Sweden Siljan", "Sweden Kungsangen", "Sweden Orebro", "Sweden Arlanda", "Sweden Bromma", "Sweden Harnosand", "Sweden Umea", "Sweden Visby", "Switzerland Belp", "Switzerland Geneva", "Switzerland Sion", "Switzerland Zurich", "Syria Damascus Intl.", "Taiwan Kaohsiung Intl.", "Taiwan Chiang Kai Shek", "Tanzania Dar Es Salaam", "Tanzania Kilimanjaro", "Tanzania Mtwara", "Tanzania Mwanza", "Tanzania Karume", "Tanzania Tabora", "Tanzania Tanga", "Tanzania Kisauni", "Tchad N'Djamena", "Thailand Bangkok", "Thailand Chiang Mai", "Thailand Phuket", "Thailand Hat Yai Intl.", "Thailand Surat Thani", "Togo Tokoin", "Trinidad & Tobago Piarco", "Trinidad & Tobago Crown Point", "Tunisia Zarzis", "Tunisia Habib Bourguiba Intl", "Tunisia Thyna", "Tunisia Nefta", "Tunisia Carthage", "Turkey Sakirpasa", "Turkey Esenboga", "Turkey Mugla", "Turkey Ataturk", "Turkey Adnan Menderes", "Turkmenistan Ashkhabad", "Uganda Entebbe", "Ukraine Borispol", "Ukraine Lvov", "Ukraine Odessa", "United Arab Emirates Abu Dhabi Intl", "United Arab Emirates Bateen", "United Arab Emirates Dubai", "United Arab Emirates Fujairah Intl.", "United Arab Emirates Ras Al Khaimah", "United Arab Emirates Sharjah Intl.", "United Kingdom Aberdeen", "United Kingdom Alderney", "United Kingdom Wideawake", "United Kingdom Walney Island", "United Kingdom Bedford", "United Kingdom Aldergrove", "United Kingdom City", "United Kingdom Bembridge", "United Kingdom Benbecula", "United Kingdom Biggin Hill", "United Kingdom Birmingham", "United Kingdom Blackbushe", "United Kingdom Blackpool", "United Kingdom Bournemouth", "United Kingdom Bristol", "United Kingdom Cambridge", "United Kingdom Cardiff", "United Kingdom Carlisle", "United Kingdom Coventry", "United Kingdom Cranfield", "United Kingdom Dundee", "United Kingdom East Midlands", "United Kingdom Edinburgh", "United Kingdom Exeter", "United Kingdom Glasgow", "United Kingdom Gloucestershire", "United Kingdom Guernsey", "United Kingdom Humberside", "United Kingdom Dalcross", "United Kingdom Islay", "United Kingdom Ronaldsway", "United Kingdom Jersey", "United Kingdom Kirkwall", "United Kingdom Leeds Bradford", "United Kingdom Liverpool", "United Kingdom City", "United Kingdom Gatwick", "United Kingdom Heathrow", "United Kingdom Stansted", "United Kingdom Luton", "United Kingdom Lydd", "United Kingdom Manchester", "United Kingdom Manston", "United Kingdom Newcastle", "United Kingdom Kidlington", "United Kingdom City", "United Kingdom Prestwick", "United Kingdom Eastleigh", "United Kingdom Southend", "United Kingdom Stornoway", "United Kingdom Sumburgh", "United Kingdom Swansea", "United Kingdom Teeside", "United Kingdom Tiree", "United Kingdom Unst", "United Kingdom Wick", "United States Albuquerque", "United States Wm. B. Hartsfield", "United States Atlantic City", "United States Washington Intl", "United States Bangor Intl", "United States Bedford", "United States Birmingham Intl", "United States Logan Intl", "United States Buffalo", "United States Burlington", "United States Natrona County Intl", "United States Sanford", "United States Charleston", "United States Douglas", "United States Lovell Field", "United States Cheyenne", "United States Chicago O'Hare", "United States Northern Kentucky Intl", "United States Clearwater", "United States Cleveland", "United States City Of Colarado", "United States Columbia Met", "United States Port Columbus", "United States Dallas Fort Worth", "United States Love Field", "United States Denver Intl", "United States Des Moines", "United States Wayne", "United States Willow Run", "United States Duluth Intl", "United States Snohomish County", "United States Hector Intl", "United States Fort Lauderdale", "United States Fresno", "United States Walker Field", "United States Great Falls", "United States Houston Intl", "United States Huntsville", "United States Indianapolis Intl", "United States Jacksonville Intl", "United States Kansas City Intl", "United States Knoxville", "United States Las Vegas", "United States Long Beach", "United States Los Angeles Intl", "United States Standiford Field", "United States Memphis Intl", "United States Miami Intl", "United States Milwaukee", "United States Minneapolis", "United States Montgomery", "United States Grant County", "United States Nashville", "United States New Orleans", "United States John F. Kennedy", "United States La Guardia", "United States Newark Intl", "United States Stewart", "United States Williamsburg Intl", "United States Niagara Falls", "United States Norfolk Intl", "United States Oakland", "United States Eppley", "United States Ontario Intl", "United States Orlando", "United States Philadelphia", "United States Sky Harbor", "United States Pittsburgh", "United States Portland Intl", "United States Portland Intl Jetport", "United States Northern Maine Regional", "United States Pueblo Memorial", "United States Cannon Intl", "United States Richmond", "United States Metroplolitan", "United States Salt Lake City", "United States San Antonio Intl", "United States San Diego", "United States San Francisco", "United States Savannah", "United States Tacoma", "United States King County Intl", "United States Sioux Falls", "United States Spokane Intl", "United States St. Louis Intl", "United States Hancock Intl", "United States Tampa Intl", "United States Dulles", "United States National", "United States West Palm Beach", "United States New Hanover County", "United States Windsor Locks", "Uruguay Carrasco", "Uzbekistan Samarkand", "Uzbekistan Yuzhnyy", "Venezuela Simon Bolivar", "Venezuela La Chinita", "Venezuela Del Caribe", "Vietnam Danang", "Vietnam Noibai", "Vietnam Tansonnhat", "Windward Islands Hewanorra Intl", "Yemen Arab Republic Aden", "Yemen Arab Republic Hodeidah", "Yemen Arab Republic Sanaa Intl.", "Yemen Arab Republic Ganed", "Yugoslavia Belgrade", "Yugoslavia Mostar", "Yugoslavia Ohrid", "Yugoslavia Podgorica", "Yugoslavia Sarajevo", "Yugoslavia Skopje", "Yugoslavia Tivat", "Zaire Ndjili", "Zaire Bangoka", "Zaire Barrer Luano", "Zaire Mbuji-Mayi", "Zambia Kasama", "Zambia Livingstone", "Zambia Lusaka Intl.", "Zambia Mansa", "Zambia Mongu", "Zambia N'Dola", "Zimbabwae Bulawayo", "Zimbabwae Buffalo Range", "Zimbabwae Charles Prince", "Zimbabwae Harare Intl.", "Zimbabwae National Park", "Zimbabwae Kariba", "Zimbabwae Masvingo", "Zimbabwae Victoria Falls"})
        Me.ComboBox4.Location = New System.Drawing.Point(336, 340)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(286, 26)
        Me.ComboBox4.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(921, 340)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 22)
        Me.DateTimePicker1.TabIndex = 11
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(921, 480)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(206, 22)
        Me.DateTimePicker2.TabIndex = 12
        Me.DateTimePicker2.Value = New Date(2021, 12, 30, 0, 0, 0, 0)
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(764, 649)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 48)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Annuler"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Button6.Location = New System.Drawing.Point(948, 649)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 48)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Afficher"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 734)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "choix de vol"
        Me.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
