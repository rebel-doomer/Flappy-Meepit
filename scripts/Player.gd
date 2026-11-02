extends RigidBody2D
class_name Player

@export var jump_power: float = 100

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass

# this is the function that will run every frame of the game (FPS)
func _process(delta: float) -> void: # public means other objects can see it, override means the parent (rigitbody2) already had made this function but we are adding new code to execute when this function is running, void just executes code but does not deliver any data back, paranthesis parameters is stuff it is supposed to take in when you call the function
	if Input.is_key_pressed(KEY_SPACE): print("SPACE HELD")
	if Input.is_action_just_pressed("jump"): print("JUMP JUST PRESSED")
	# super(delta) # this tells it to just run the base version (version that rigitbody2d has) if you remove this then it fails to run all the code from rigitbody2d/parent function
	if Input.is_action_just_pressed("jump"):
		var impulse: Vector2 = Vector2(0, -jump_power) # x and y axis
		apply_impulse(impulse)
		print(">>> SPACEBAR PRESSED! APPLYING IMPULSE! <<<")

# Commented-out original block, kept for reference:
#
# # Called every frame. 'delta' is the elapsed time since the previous frame.
# func _process(delta: float) -> void:
# 	pass
