import numpy as np
import matplotlib.pyplot as plt

# Car parameters
wheelbase = 2.5  # meters
max_steering_angle = np.radians(30)  # 30 degrees

# Simulation parameters
dt = 0.1  # time step (seconds)
total_time = 10  # seconds
num_steps = int(total_time / dt)

# Initial state
x, y, theta = 0, 0, 0  # position (m), orientation (radians)
speed = 5  # m/s (constant)

# Steering function
def desired_steering(t):
    if t < 5:
        return 0  # straight
    else:
        return max_steering_angle  # turn right

# Simulation loop
trajectory = []
for step in range(num_steps):
    t = step * dt
    steering_angle = desired_steering(t)

    # Update state
    x += speed * np.cos(theta) * dt
    y += speed * np.sin(theta) * dt
    theta += (speed / wheelbase) * np.tan(steering_angle) * dt

    trajectory.append((x, y))

# Plot results
trajectory = np.array(trajectory)
plt.plot(trajectory[:, 0], trajectory[:, 1])
plt.xlabel('X Position (m)')
plt.ylabel('Y Position (m)')
plt.title('Car Trajectory')
plt.grid(True)
plt.show()