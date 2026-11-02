extends Area2D
class_name KillZone

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	# super()
	body_entered.connect(handle_player_overlap)

func handle_player_overlap(body: Node2D) -> void:
	if body is Player: # the game restarts the level in the middle of a physics step. thus, added call_deferred() to tell Godot to do the restart a moment later, once that step is done.
		get_tree().call_deferred("reload_current_scene")

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass
