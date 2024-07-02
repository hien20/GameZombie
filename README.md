Tên đề tài: Xây dựng Game 2D Platform "Around us".
Công nghệ công cụ: Unity 2D with C# Script, Unity Hub 2022.3.7f1, Visual Studio 2022.
Tên Game: Around us
Tên Game viết tắt: AUS
Thể loại: 2D Platform - là một thể loại game trong đó người chơi điều khiển một nhân vật trên một màn hình hai chiều và cố gắng vượt qua màn chơi bằng cách tiêu diệt được các người bị ký sinh và tìm đến Boss cuối để tiêu diệt. Thể loại này thường tập trung và nhanh nhạy của nhân vật chính để vượt qua trò chơi.
1.	Mô tả các scene
1.1 Main Menu Scene
	Mô tả: Đây là scene đầu tiên người chơi thấy khi khởi động game. Nó cung cấp các tùy chọn để bắt đầu chơi, thay đổi cài đặt hoặc thoát khỏi game.
	Thành phần chính:
		-Background Image: Hình ảnh nền giúp tạo không khí cho game.
		-Title Text: Tên game, thường được đặt ở vị trí nổi bật trên màn hình.
		-Buttons: Các nút bấm để tương tác, bao gồm:
●	Play Button: Bắt đầu game và chuyển sang Game Play Scene.
●	Instruct Button: Hướng dẫn cách chơi và điều khiển nhân vật,...
●	Quit Button: Thoát khỏi game.
 ![image](https://github.com/hien20/GameZombie/assets/85773590/ece1c00a-a183-4078-b967-0d5e0c3d8295)

Hình 1:  Secene Menu
1.2 Main Game Play
	Mô tả: Đây là scene chính nơi diễn ra gameplay. Tại đây, người chơi điều khiển nhân vật chính để vượt qua các thử thách, đánh bại kẻ thù.
	Thành phần chính:
		-Player: Nhân vật chính mà người chơi điều khiển. Được trang bị các component như Sprite Renderer, Rigidbody2D, Collider2D, và các script điều khiển.
		-Enemies: Các kẻ thù xuất hiện trong game. Mỗi kẻ thù có các component và script quản lý hành vi của chúng.
		-Platforms: Các nền tảng mà nhân vật có thể đứng hoặc tương tác.
		-Background: Hình nền hoặc các lớp nền để tạo cảm giác chiều sâu và bối cảnh cho gameplay.
		-UI Elements: Các thành phần giao diện người dùng như thanh máu và các thông tin khác liên quan đến người chơi.

1.3 Game Over scene
	Mô tả: Scene này xuất hiện khi người chơi thua cuộc. Nó thông báo cho người chơi rằng game đã kết thúc và cung cấp các tùy chọn để tiếp tục chơi hoặc thoát.
	Thành phần chính:
		-Game Over Text: Thông báo rõ ràng rằng game đã kết thúc.
		-Buttons: Các nút bấm để tương tác, bao gồm:
●	Try Again Button: Khởi động lại game từ đầu.
●	Main Menu Button: Quay lại Main Menu Scene.
 ![image](https://github.com/hien20/GameZombie/assets/85773590/b96c3ebb-d8ec-4b15-a15e-40ed481b44e8)

Hình 2: Over scene
1.4 Game Victory Scene
	Mô tả: Scene này xuất hiện khi người chơi hoàn thành game hoặc đạt được mục tiêu cuối cùng. Nó thông báo cho người chơi về chiến thắng và cung cấp các tùy chọn để tiếp tục chơi hoặc thoát.
	
	Thành phần chính:
		-Victory Text: Thông báo rằng người chơi đã chiến thắng.
		-Buttons: Các nút bấm để tương tác, bao gồm:
●	Play Again Button: Chơi lại từ đầu.
●	Main Menu Button: Quay lại Main Menu Scene.
 ![image](https://github.com/hien20/GameZombie/assets/85773590/db69d3b5-78b0-4032-9683-d5d1ca1d6a06)

Hình 3: Main Victory
1.5 Instruction Scene
	Mô tả: Scene này cung cấp các hướng dẫn cơ bản cho người chơi, giúp họ hiểu rõ cách chơi, các điều khiển, và các quy tắc trong game. Đây có thể là phần quan trọng đặc biệt đối với những người chơi mới hoặc khi game có các cơ chế phức tạp.
	Thành phần chính:
		-Background Image: Hình ảnh nền có thể là đơn giản để không làm phân tán sự chú ý khỏi nội dung hướng dẫn.
		-Instruction Text: Các đoạn văn bản mô tả chi tiết về cách điều khiển, mục tiêu của game, và các mẹo chơi.
		-Images/Icons: Hình ảnh hoặc biểu tượng minh họa cho các nút bấm, hành động, hoặc các đối tượng trong game.
		-Buttons: Các nút bấm để người chơi có thể chuyển sang scene khác hoặc quay lại menu chính.
		-Quit Button: Trở về Main Menu Scene.
  ![image](https://github.com/hien20/GameZombie/assets/85773590/2ea1ea44-aad2-4733-b6f5-ba5476eb9ef9)

 Hình 4:Scene Instruct
1.6 Pause Scene 
	Mô tả: Scene này xuất hiện khi người chơi tạm dừng game. Nó cho phép người chơi tạm nghỉ và quay lại gameplay khi sẵn sàng.
	Thành phần chính:
		-Pause Text: Thông báo rằng game đang tạm dừng.
		-Continue Button: Tiếp tục chơi game.
		-Main Menu Button: Quay lại Main Menu Scene.
 
Hình 5: Scene pause
2.	Mô tả các game object và các component liên quan
2.1 Player 
 ![image](https://github.com/hien20/GameZombie/assets/85773590/2515ed6c-4e0a-4044-bef8-2144c4b1d1d8)

Hình 6: Nhân vật
	Mô tả: Nhân vật chính mà người chơi điều khiển. Thường là trung tâm của trải nghiệm game, với khả năng di chuyển, nhảy, và tấn công.
	Thành phần chính:
		-Sprite Renderer: Hiển thị hình ảnh của nhân vật. Thiết lập sprite để đại diện cho nhân vật.
		-Rigidbody2D: Quản lý vật lý 2D của nhân vật, cho phép di chuyển và va chạm với môi trường.
		-Collider2D: Xác định vùng va chạm của nhân vật. Thường là Box Collider 2D hoặc Circle Collider 2D.
		-Animator: Điều khiển các hoạt hình của nhân vật, giúp nhân vật chuyển động mượt mà và sống động.
		-PlayerController Script: Script điều khiển hành động của nhân vật như di chuyển, nhảy, và tấn công.
2.2 Enemy 
	Mô tả: Các đối thủ mà người chơi phải đối mặt và vượt qua trong game.
	Thành phần chính:
		-Sprite Renderer: Hiển thị hình ảnh của kẻ thù.
		-Rigidbody2D: Quản lý vật lý 2D của kẻ thù.
		-Collider2D: Xác định vùng va chạm của kẻ thù.
		-Animator: Điều khiển các hoạt hình của kẻ thù.
		-EnemyAI Script: Script điều khiển hành vi của kẻ thù, như di chuyển và tấn công.
2.3 Platforms
	Mô tả: Các nền tảng mà nhân vật có thể va chạm hoặc tương tác.
	Thành phần chính:
		-Sprite Renderer: Hiển thị hình ảnh của nền tảng.
		-Collider2D: Xác định vùng va chạm của nền tảng. Thường là Box Collider 2D.
2.4 Map 
	Mô tả tổng quan: Bản đồ trong game 2D là yếu tố chính giúp định hình không gian chơi và hướng dẫn người chơi qua các cấp độ. Bản đồ thường bao gồm các yếu tố môi trường, chướng ngại vật, và các vật phẩm tương tác, tạo nên một sân chơi đa dạng và thú vị cho người chơi.
	Thành phần chính của Map:
		-Tilemap: Sử dụng hệ thống Tilemap của Unity để xây dựng nền tảng và địa hình của bản đồ.
		-Environmental Objects: Các đối tượng môi trường như cây cối, đá, và tòa nhà.
		-Obstacles: Các chướng ngại vật như các vật dụng, nội thất.
		-Các công cụ và Component sử dụng:
●	Tilemap: Công cụ mạnh mẽ của Unity để xây dựng các bản đồ 2D một cách dễ dàng và hiệu quả.
●	Composite Collider 2D: Dùng để kết hợp nhiều collider nhỏ thành một collider lớn, giúp quản lý các va chạm dễ dàng hơn.
●	Grid: Quản lý vị trí của các Tile trong bản đồ.
 ![image](https://github.com/hien20/GameZombie/assets/85773590/6b200080-7cf8-4b7e-b3bf-80f1686a91a5)

Hình 7: Map 1


 ![image](https://github.com/hien20/GameZombie/assets/85773590/a038bd34-1ba6-4871-a174-8d0e994f9262)

Hình 8: Map 2
 ![image](https://github.com/hien20/GameZombie/assets/85773590/9d700bd7-2b30-408a-a952-a717e31c00fb)

Hình 9: Map 3
 ![image](https://github.com/hien20/GameZombie/assets/85773590/b08638ee-84bb-407e-8ea3-7f542d07db50)

Hình 10: Map 4
3.	Mô tả các lớp C# script
3.1 PlayerController Script
	Mô tả: Điều khiển hành động của nhân vật chính như di chuyển.
	Thành phần chính:
		-MoveSpeed: Tốc độ di chuyển của nhân vật.
		-rb: Thành phần Rigidbody2D của nhân vật để quản lý vật lý.
		-Animator: Thành phần Animator để quản lý các hoạt hình của nhân vật.
3.2 Enemy Script
	Mô tả: Điều khiển hành vi của kẻ thù như di chuyển.
	Thành phần chính:
		-MoveSpeed: Tốc độ di chuyển của kẻ thù.
		-rb: Thành phần Rigidbody2D của kẻ thù.
		-Aimator: Thành phần Animator để quản lý các hoạt hình của kẻ thù.
3.3 MainMenu Script
	Mô tả: Quản lý các hành động trong menu chính, như bắt đầu game, vào phần hướng dẫn hoặc thoát game.
	Thành phần chính:
		-PlayGame(): Hàm bắt đầu game.
		-OpenInstruct(): Hàm mở phần hướng dẫn.
		-QuitGame(): Hàm thoát game.
3.4 Attack Script
	Mô tả: Quản lý các hành động tấn công của nhân vật.
	Thành phần chính:
		-attackDamage: Sát thương gây ra bởi đòn tấn công.
3.5 AudioManager Script
	Mô tả: Quản lý âm thanh trong game, bao gồm âm thanh nền và các hiệu ứng âm thanh.
	Thành phần chính:
		-backgroundMusic: Âm nhạc nền.
3.6 Boss Script
	Mô tả: Quản lý hành vi và tấn công của boss trong game.
	Thành phần chính:
		-health: Thanh máu của boss.
		-attackPatterns: Cách công của boss.
 ![image](https://github.com/hien20/GameZombie/assets/85773590/c31d2671-16d5-4417-a7ed-879329deba8b)

Hình 11 : Zombie
 ![image](https://github.com/hien20/GameZombie/assets/85773590/5afb49b9-09dc-4a7b-a488-d5c1892c001b)

Hình 12: Boss

3.7 DamageableCharacter Script
	Mô tả: Quản lý các nhân vật zombie có thể bị gây sát thương
	Thành phần chính:
		-health: Thanh máu của nhân vật và zombie.
		-TakeDamage(): Hàm để nhận sát thương.


3.8 DetectionZone Script
	Mô tả: Quản lý vùng phát hiện của kẻ thù hoặc boss, xác định khi nào nhân vật đi vào vùng phát hiện để kích hoạt hành động.
	Thành phần chính:
		-detectionRange: Phạm vi phát hiện.
		-isPlayerInRange: Kiểm tra xem nhân vật có ở trong vùng phát hiện hay không.
3.9 HealthBar Script
	Mô tả: Quản lý thanh máu của nhân vật, hiển thị sức khỏe hiện tại của nhân vật.
	Thành phần chính:
		-healthBar: Máu.
		-maxHealth: Máu tối đa của nhân vật và boss.
3.10 LevelMove Script
	Mô tả: Quản lý việc di chuyển giữa các màn (Scene) trong game.
	Thành phần chính:
		-levelIndex: Chỉ số của map cần chuyển đến.
		-SceneManager: Dùng để tải map mới.
3.11 PauseMenu Script
	Mô tả: Quản lý menu tạm dừng, cho phép người chơi tạm dừng game và truy cập các tùy chọn như tiếp tục hoặc thoát về menu chính.
	Thành phần chính:
		-Pause(): Hàm tạm dừng game.
		-Continue(): Hàm tiếp tục game.
		-OpenMainMenu(): Hàm mở menu chính.
3.12 WinLoseMenu Script
	Mô tả: Quản lý menu thắng/thua, hiển thị khi người chơi hoàn thành tất cả thử thách hoặc thất bại.
	Thành phần chính:
		-Win(): Hàm xử lý khi người chơi thắng.
		-Lose(): Hàm xử lý khi người chơi thua.
		-QuitToMenu(): Hàm quay lại menu chính.
4.	Âm thanh
4.1 Âm thanh nền
	Âm thanh nền là yếu tố quan trọng tạo nên bầu không khí cho game. Nó giúp tạo cảm giác nhập vai và duy trì hứng thú cho người chơi. Trong Unity, âm thanh nền thường được quản lý bởi một AudioSource.
	Cài đặt AudioSource cho âm thanh nền:
		-Tạo GameObject cho âm thanh nền: Tạo một GameObject mới trong Unity và đặt tên là "AudioManager".
		-Thêm AudioSource: Thêm component AudioSource vào GameObject này.
		-Gán âm thanh: Gán clip âm thanh nền vào AudioSource.
		-Cài đặt loop và play on awake: Đánh dấu vào các ô "Loop" và "Play On Awake" để âm thanh nền lặp lại và phát ngay khi game bắt đầu.
