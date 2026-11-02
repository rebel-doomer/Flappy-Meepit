extends Area2D
class_name Pipes

@export var _speed: float = 200.0

var _has_scored: bool = false # Prevents scoring multiple times on the same pipe

func _ready() -> void:
	body_entered.connect(handle_player_overlap)

func _process(delta: float) -> void:
	position -= Vector2(_speed * delta, 0)
	if position.x < -170:
		var rand_pipe_height: float = randf_range(-50.0, 150.0)
		position = Vector2(442, rand_pipe_height)
		_has_scored = false # Reset when pipe recycles

func handle_player_overlap(body: Node2D) -> void:
	if body is Player:
		# If player hits the main pipe, restart the game
		get_tree().call_deferred("reload_current_scene")

# Bridge method to catch whatever default name Godot generated in the editor
func _on_body_entered(body: Node2D) -> void:
	on_score_area_body_entered(body)

# The core scoring logic method
func on_score_area_body_entered(body: Node2D) -> void:
	if body is Player and not _has_scored:
		_has_scored = true

		# Find your unique score label and add 1 directly
		var score_label: Label = get_tree().current_scene.get_node("%ScoreLabel") as Label
		if score_label != null:
			var current_score: int = score_label.text.strip_edges().to_int()
			score_label.text = str(current_score + 1)
